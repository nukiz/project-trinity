using Memory;
using Project_Trinity.Trinity.feature.player;
using System;
using System.Drawing;
using System.Windows.Forms;
using Project_Trinity.Trinity.feature.player;
using System.Threading;

namespace Project_Trinity
{


    public partial class GUI : Form
    {
        private bool mouseDown; // booleans for dragging the window
        private Point lastLocation;
        Boolean toggled = false;
        Mem m = new Mem();

        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            ClockTimer.Start();
            if (!m.OpenProcess("Growtopia.exe"))
            {
                AttachTimer.Start();
            }
            GameSpeedVal.Text = Convert.ToString(GameSpeedModifier.Value);
        }


        private void AttachTimer_Tick(object sender, EventArgs e)
        {
            if (!m.OpenProcess("Growtopia.exe"))
            {
                StatusLabel.Text = "Waiting...";
                StatusLabel.ForeColor = Color.FromArgb(192, 192, 0);
                m.OpenProcess("Growtopia.exe");

            }

            if (m.OpenProcess("Growtopia.exe"))
            {
                StatusLabel.Text = "Active";
                StatusLabel.ForeColor = Color.Lime;
                AttachTimer.Stop();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FeaturesButton_Click(object sender, EventArgs e)
        {
            FeatureConnector.BackColor = Color.FromArgb(18, 18, 18);                  // and making the one we have here actually connect :^)
            RendererConnector.BackColor = Color.FromArgb(21, 21, 21);                 // resetting the other connectors to their original back colors :^)
            ProxyConnector.BackColor = Color.FromArgb(21, 21, 21);
            UtilitiesConnector.BackColor = Color.FromArgb(21, 21, 21);


        }

        private void RenderButton_Click(object sender, EventArgs e)
        {
            RendererConnector.BackColor = Color.FromArgb(18, 18, 18);                  // and making the one we have here actually connect :^)
            FeatureConnector.BackColor = Color.FromArgb(21, 21, 21);                 // resetting the other connectors to their original back colors :^)
            ProxyConnector.BackColor = Color.FromArgb(21, 21, 21);
            UtilitiesConnector.BackColor = Color.FromArgb(21, 21, 21);


        }

        private void ProxyButton_Click(object sender, EventArgs e)
        {
            ProxyConnector.BackColor = Color.FromArgb(18, 18, 18);                  // and making the one we have here actually connect :^)
            FeatureConnector.BackColor = Color.FromArgb(21, 21, 21);                 // resetting the other connectors to their original back colors :^)
            RendererConnector.BackColor = Color.FromArgb(21, 21, 21);
            UtilitiesConnector.BackColor = Color.FromArgb(21, 21, 21);


        }

        private void UtilitiesButton_Click(object sender, EventArgs e)
        {
            UtilitiesConnector.BackColor = Color.FromArgb(18, 18, 18);                  // and making the one we have here actually connect :^)
            FeatureConnector.BackColor = Color.FromArgb(21, 21, 21);                 // resetting the other connectors to their original back colors :^)
            ProxyConnector.BackColor = Color.FromArgb(21, 21, 21);
            RendererConnector.BackColor = Color.FromArgb(21, 21, 21);


        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH") + ":" + DateTime.Now.ToString("mm"); // makes it look better instead of for example 22.31 to 22:31
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainTab_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void StatusPrefix_Click(object sender, EventArgs e)
        {

        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e) { }

        private void CustomCheckbox1_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox1.BackColor = Color.FromArgb(65, 29, 105);
                Antibounce.onEnable();
            }
            else
            {
                CustomCheckbox1.BackColor = Color.FromArgb(21, 21, 21);
                Antibounce.onDisable();
            }

        }

        private void CustomCheckbox2_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox2.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox2.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void GameSpeedModifier_ValueChanged(object sender, EventArgs e)
        {
            GameSpeedVal.Text = Convert.ToString(GameSpeedModifier.Value);
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void CustomCheckbox3_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox3.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox3.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox4_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox4.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox4.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox5_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox5.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox5.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox6_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox6.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox6.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox7_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox7.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox7.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox8_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox8.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox8.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox9_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox9.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox9.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox10_Paint(object sender, PaintEventArgs e) { } //these are annoying as removing them also needs shit done in Designer.cs

        private void CustomCheckbox10_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox10.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox10.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox11_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox11.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox11.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox12_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox12.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox12.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox13_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox13.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox13.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox14_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox14.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox14.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox15_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox15.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox15.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox16_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox16.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox16.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox17_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox17.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox17.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox18_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox18.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox18.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox19_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox19.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox19.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox20_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox20.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox20.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox21_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox21.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox21.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox22_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox22.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox22.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void CustomCheckbox23_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                CustomCheckbox23.BackColor = Color.FromArgb(65, 29, 105);
                ModFly.onEnable();
            }
            else
            {
                CustomCheckbox23.BackColor = Color.FromArgb(21, 21, 21);
                ModFly.onDisable();
            }
        }

        private void AntiBanCheck_Click(object sender, EventArgs e)
        {
            toggled = !toggled;
            if (toggled)
            {
                AntiBanCheck.BackColor = Color.FromArgb(65, 29, 105);
                Antiban.onEnable();
            }
            else
            {
                AntiBanCheck.BackColor = Color.FromArgb(21, 21, 21);
                Antiban.onDisable();
            }
        }
    }
}
