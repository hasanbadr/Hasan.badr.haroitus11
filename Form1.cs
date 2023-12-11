namespace Hasan.badr.haroitus11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Heit‰BT_Click(object sender, EventArgs e)
        {
            piirrNoppa(Noppa01PB);
            piirrNoppa(Noppa02PB);

        }
        private void piirrNoppa(PictureBox NoppaBox)
        {
            Random satunnainen = new Random();
            int noppa = satunnainen.Next(1, 7);
            switch (noppa)
            {
                case 1:
                    NoppaBox.Image = Properties.Resources.Nopanheitto1;
                    break;
                case 2:
                    NoppaBox.Image = Properties.Resources.Nopanheitto2;
                    break;
                case 3:
                    NoppaBox.Image = Properties.Resources.Nopanheitto3;
                    break;
                case 4:
                    NoppaBox.Image = Properties.Resources.Nopanheitto4;
                    break;
                case 5:
                    NoppaBox.Image = Properties.Resources.Nopanheitto5;
                    break;
                case 6:
                    NoppaBox.Image = Properties.Resources.Nopanheitto6;
                    break;
            }
        }
    }
}