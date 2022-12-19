namespace AnslagsTavlaExempel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetActivePanel(startSida1);//Sätter Startsidan till den sidan som man kommer in på när man först laddar in programmet
        }

        public void SetActivePanel(UserControl control)
        {
            busstider1.Visible = false;
            väder1.Visible = false;
            aktiviteter1.Visible = false;
            dagsschema1.Visible = false;
            startSida1.Visible = false;
            control.Visible = true;
        }

        private void home_Button_Click(object sender, EventArgs e)
        {
            SetActivePanel(startSida1);
        }

        private void dayScheme_Button_Click(object sender, EventArgs e)
        {
            SetActivePanel(dagsschema1);
        }

        private void activities_Button_Click(object sender, EventArgs e)
        {
            SetActivePanel(aktiviteter1);
        }

        private void bussTimes_Button_Click(object sender, EventArgs e)
        {
            SetActivePanel(busstider1);
        }

        private void wheater_Button_Click(object sender, EventArgs e)
        {
            SetActivePanel(väder1);
        }
    }
}