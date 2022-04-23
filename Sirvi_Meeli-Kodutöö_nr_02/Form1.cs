namespace Sirvi_Meeli_Kodutöö_nr_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_arvesta_Click(object sender, EventArgs e)
        {
            matemaatika arv = new matemaatika();
           
            try
            {
                arv.number1 = Convert.ToSingle(txt_esimene.Text);
                arv.number2 = Convert.ToSingle(txt_teine.Text);

                if (btn_liida.Checked == false &&
                    btn_lahuta.Checked == false &&
                    btn_korruta.Checked == false &&
                    btn_jaga.Checked == false)
                    throw new InvalidOperationException();

                else if (btn_liida.Checked)
                {
                    arv.tehing = "+";
                }
                else if (btn_lahuta.Checked)
                {
                    arv.tehing = "-";
                }
                else if (btn_korruta.Checked)
                {
                    arv.tehing = "*";
                }
                else if (btn_jaga.Checked)
                {
                    if (arv.number1 == 0 || arv.number2 == 0)
                    {
                        throw new DivideByZeroException("Division by zero is not allowed");
                    }

                    else
                    {
                        arv.tehing = "/";
                    }
                }
                

                //tulemus
                Single tulemused = arv.arvutus();
                vastus.Text = Convert.ToString(arv.number1) + arv.tehing 
                    + Convert.ToString(arv.number2) + " = " + Convert.ToString(tulemused);
            }

            //veateated

            catch (InvalidOperationException) //kui pole valitud tehingut
            {
                vastus.Text = "";
                MessageBox.Show("Vali tehe", "Viga",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            catch (DivideByZeroException) //kui jagamistehte korral on sisestud ühe numbrina 0
            {
                vastus.Text = "";
                MessageBox.Show("Nulliga jagamine on keelatud", "Viga",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (FormatException) // kui mõlemad väljad on tühjad; kui numbrid on eraldatud koma asemel punktiga; kui sisestatud on tähed
            {
                vastus.Text = "";
                MessageBox.Show("Sisesta korrektne number", "Viga",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}