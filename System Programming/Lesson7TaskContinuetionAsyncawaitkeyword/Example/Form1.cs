using Timer = System.Windows.Forms.Timer;
namespace Example
{
    public partial class Form1 : Form
    {
        private readonly Timer _timer;
        public Form1()
        {
            InitializeComponent();
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += (o, s) => { label1.Text = $"{DateTime.Now:HH:mm:ss}"; };
            _timer.Start();
        }

        #region Sync

        private void AddLog(string log)
        {
            if (!string.IsNullOrWhiteSpace(log))
                log = $"{log}: {DateTime.Now:HH:mm:ss}";
            listBox1.Items.Add(log);
        }

        private void ChangeColor(string name)
        {
            var btn = panel1.Controls[name] as Button;
            if (btn is not null) btn.BackColor = Color.Green;
        }

        private void YumurtaniQir()
        {
            Thread.Sleep(500);
            AddLog("Yumurta Qirildi");
            ChangeColor("btnQir");
        }

        private void YumurtaniQar()
        {
            Thread.Sleep(500);
            AddLog("Yumurta Qarishdirildi");
            ChangeColor("btnQar");
        }

        private void QaziYandir()
        {
            Thread.Sleep(500);
            AddLog("Qaz Yandirildi");
            ChangeColor("btnYan");
        }

        private void TavaniQizdir()
        {
            Thread.Sleep(500);
            AddLog("Tava Qizdi");
            ChangeColor("btnQiz");
        }

        private void YagTok()
        {
            Thread.Sleep(500);
            AddLog("Yag tokuldu");
            ChangeColor("btnYag");
        }

        private void YumurtaTok()
        {
            Thread.Sleep(500);
            AddLog("Yumurta tokuldu");
            ChangeColor("btnTk");
        }

        private void DuzTok()
        {
            Thread.Sleep(500);
            AddLog("Duz tokuldu");
            ChangeColor("btnDuz");
        }

        private void Bishir()
        {
            Thread.Sleep(500);
            AddLog("Bishirildi");
            ChangeColor("btnBish");
        }

        private void ServisEt()
        {
            Thread.Sleep(500);
            AddLog("Servis oldundu");
            ChangeColor("btnSer");
        }


        #endregion

        #region Async


        private async Task YumurtaniQirAsync()
        {
            await Task.Delay(500);
            AddLog("Yumurta Qirildi");
            ChangeColor("btnQir");
        }

        private async Task YumurtaniQarAsync()
        {
            await Task.Delay(500);
            AddLog("Yumurta Qarishdirildi");
            ChangeColor("btnQar");
        }

        private async Task QaziYandirAsync()
        {
            await Task.Delay(500);
            AddLog("Qaz Yandirildi");
            ChangeColor("btnYan");
        }

        private async Task TavaniQizdirAsync()
        {
            await Task.Delay(500);
            AddLog("Tava Qizdi");
            ChangeColor("btnQiz");
        }

        private async Task YagTokAsync()
        {
            await Task.Delay(500);
            AddLog("Yag tokuldu");
            ChangeColor("btnYag");
        }

        private async Task YumurtaTokAsync()
        {
            await Task.Delay(500);
            AddLog("Yumurta tokuldu");
            ChangeColor("btnTk");
        }

        private async Task DuzTokAsync()
        {
            await Task.Delay(500);
            AddLog("Duz tokuldu");
            ChangeColor("btnDuz");
        }

        private async Task BishirAsync()
        {
            await Task.Delay(500);
            AddLog("Bishirildi");
            ChangeColor("btnBish");
        }

        private async Task ServisEtAsync()
        {
            await Task.Delay(500);
            AddLog("Servis oldundu");
            ChangeColor("btnSer");
        }


        #endregion


        private void BtnSync_Click(object sender, EventArgs e)
        {
            YumurtaniQir();
            YumurtaniQar();
            DuzTok();
            QaziYandir();
            TavaniQizdir();
            YagTok();
            YumurtaTok();
            Bishir();
            ServisEt();
        }

        private async void BtnAsync_Click(object sender, EventArgs e)
        {
            Task yumurtaTask = await YumurtaniQirAsync().ContinueWith(
                async _ =>
                {
                    await YumurtaniQarAsync();
                    await DuzTokAsync();
                });

            Task bishirmeHazirliqTask = await QaziYandirAsync()
                .ContinueWith
                (
                async _ =>
                {
                    await TavaniQizdirAsync();
                    await YagTokAsync();
                });

            await Task.WhenAll(yumurtaTask, bishirmeHazirliqTask);
            await YumurtaTokAsync();
            await BishirAsync();
            await ServisEtAsync();

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            foreach (var item in panel1.Controls)
            {
                if(item is Button btn)
                    btn.BackColor = Color.White;
            }
            listBox1.Items.Clear();
        }
    }
}
