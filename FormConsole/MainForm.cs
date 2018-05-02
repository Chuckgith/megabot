using FormConsole.Sources;
using Jojatekok.PoloniexAPI;
using Jojatekok.PoloniexAPI.MarketTools;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormConsole
{
    public partial class MainForm : Form
    {
        Business BIZ = new Business();        

        Balances _balances;
        IDisposable _subsBalances;
        Signal _signal;
        IDisposable _subsSignal;
        Ticker _ticker;
        IDisposable _subsTicker;

        private CurrencyPair CurrencyPair
        {
            get
            {
                //return new CurrencyPair(tabsMarkets.SelectedTab.Text, cbbCoins.SelectedText);
                return new CurrencyPair(cbbCoins.SelectedItem.ToString());
            }
        }

        public MainForm()
        {
            InitializeComponent();
            FillCbbCoins();

            dgvTrades.Columns[5].DefaultCellStyle.Format = "N4";
            dgvTrades.Columns[6].DefaultCellStyle.Format = "N4";
            dgvTrades.Columns[7].DefaultCellStyle.Format = "N4";
            dgvTrades.Columns[8].DefaultCellStyle.Format = "N4";
            dgvTrades.Columns[9].DefaultCellStyle.Format = "C";
            dgvTrades.Columns[10].DefaultCellStyle.Format = "C";
            dgvTrades.Columns[11].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

            dgvBalances.Columns[3].DefaultCellStyle.Format = "N8";

            cbbCoins.SelectedIndex = cbbCoins.FindStringExact("usdt_btc");

            if (_balances != null) //Si existe, alors dispose objet existant (pour sortir de la boucle)
                _balances.Dispose();

            CurrencyPair currencyPair = new CurrencyPair(cbbCoins.SelectedItem.ToString());
            _balances = new Balances(currencyPair.BaseCurrency); //cré un nouvel objet pour balance
            _signal = new Signal(currencyPair);

            _subsBalances = _balances.DataSource //S'abonne à l'observable
                //.Sample(TimeSpan.FromMilliseconds(300)) //1 donnée au 300 ms pour affichage
                .ObserveOn(WindowsFormsSynchronizationContext.Current) //Reviens sur le thread du UI
                .Subscribe(x => DisplayBalances(x));

            _subsSignal = _signal.DataSource
                .ObserveOn(WindowsFormsSynchronizationContext.Current)
                .Subscribe(x => DisplaySignal(x));
        }

        private void FillCbbCoins()
        {
            cbbCoins.Items.AddRange(BIZ.GetMarket(tabsMarkets.SelectedTab.Text).ToArray());
        }

        private void DisplaySignal(EnumStates lastState)
        {
            txtBot.AppendText(lastState + Environment.NewLine);
        }

        private void btnStartBot_Click(object sender, EventArgs e)
        {
            CurrencyPair currencyPair = new CurrencyPair(cbbCoins.SelectedItem.ToString());
            _ticker = new Ticker(currencyPair, 20, 0);

            _subsTicker = _ticker.DataSource
                .ObserveOn(WindowsFormsSynchronizationContext.Current)
                .Subscribe(x => AddTrades(x));


        }

        List<TickerModel> trades = new List<TickerModel>();

        private void AddTrades(TickerModel ticker)
        {
            trades.Add(ticker);

            dgvTrades.DataSource = new List<TickerModel> { ticker };

            foreach (DataGridViewRow row in dgvTrades.Rows)
            {
                if (ticker.profit >= 0)
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else
                    row.DefaultCellStyle.BackColor = Color.LightPink;
            }
        }

        private void DisplayBalances(IList<BalanceModel> balances)
        {
            dgvBalances.DataSource = balances
                .Where(x => x.Type == CurrencyPair.BaseCurrency || x.USDT_Value > 0)
                .OrderByDescending(x => x.Type == CurrencyPair.BaseCurrency)
                .ThenBy(x => x).ToList();
        }

        //private void GetBalance(CurrencyPair currencyPair)
        //{
        //    IList<BalanceModel> balances = null;

        //    for (int attempts = 0; attempts < 5; attempts++)
        //    {
        //        try
        //        {
        //            balances = (from x in BIZ.GetBalances() select x).ToList();
        //            break;
        //        }
        //        catch (Exception ex)
        //        {
        //            txtTicker.AppendText($"{DateTime.Now} - {ex.Message}\n");
        //        }
        //        Thread.Sleep(1000);
        //    }

        //    var balanceBase = (from x in balances where x.Type == currencyPair.BaseCurrency select x.QuoteAvailable).SingleOrDefault();
        //    var balanceQuote = (from x in balances where x.Type == currencyPair.QuoteCurrency select x.USDT_Value).SingleOrDefault();

        //    if (balanceQuote < 1)
        //        lastState = EnumStates.SOLD;
        //    else
        //        lastState = EnumStates.BOUGHT;

        //    //Console.WriteLine($"lastState: {lastState}\n");
        //}
    }
}
