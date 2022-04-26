using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMania
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        
        /*Valores resultantes */
        int total = 0;
        
        
        
        /* frutas */
        int Banana = 1;
        int vbanana = 0;
        int Maça = 1;
        int vmaça = 0;
        int Abacaxi = 6;
        int vabacaxi = 0;
        int Laranja = 7;
        int vlaranja = 0;
        int Kiwi = 2;
        int vkiwi = 0;
        int Cachodeuva = 4;
        int vcachodeuva = 0;
        int Manga = 3;
        int vmanga = 0;

        /* Vinhos */
        int CabernetSauvagnon = 50;
        int vcabernetsauvagnon = 0;
        int CabernetFranc = 50;
        int vcabernetfranc = 0;
        int Tannat = 50;
        int vtannat = 0;
        int Merlot = 50;
        int vmerlot = 0;
        int Malbec = 50;
        int vmalbec = 0;
        int Risling = 50;
        int vrisling = 0;

        /* Doces */
        int Pirulito = 2;
        int vpirulito = 0;
        int BolachaSuspiro = 5;
        int vbolachasuspiro = 0;
        int CanudoDoce = 4;
        int vcanudodoce = 0;
        int PastaDeAmendoim = 10;
        int vpastadeamendoim = 0;
        int BiscoitoDeChocolate = 7;
        int vbiscoitodechococlate = 0;
        int ChocolateAoLeite = 12;
        int vchocolateaoleite = 0;

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        /* numerick up down das frutas*/ 
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                if (numericUpDown1.Value >= 1)
                {
                    vbanana = (Convert.ToInt32(numericUpDown1.Value) * Banana);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");
                    
                }
                else
                {
                    if (numericUpDown1.Value == 0)
                    {
                        vbanana = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja+ vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }
                
            }
           
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (numericUpDown2.Value >= 1)
                {
                    vmaça = (Convert.ToInt32(numericUpDown2.Value) * Maça);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown2.Value == 0)
                    {
                        vmaça = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                if (numericUpDown3.Value >= 1)
                {
                    vabacaxi = (Convert.ToInt32(numericUpDown3.Value) * Abacaxi);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown3.Value == 0)
                    {
                        vabacaxi = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (numericUpDown4.Value >= 1)
                {
                    vlaranja = (Convert.ToInt32(numericUpDown4.Value) * Laranja);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown4.Value == 0)
                    {
                        vlaranja = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                if (numericUpDown5.Value >= 1)
                {
                    vkiwi = (Convert.ToInt32(numericUpDown5.Value) * Kiwi);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown5.Value == 0)
                    {
                        vkiwi = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                if (numericUpDown6.Value >= 1)
                {
                    vcachodeuva = (Convert.ToInt32(numericUpDown6.Value) * Cachodeuva);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown6.Value == 0)
                    {
                        vcachodeuva = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                if (numericUpDown7.Value >= 1)
                {
                    vmanga = (Convert.ToInt32(numericUpDown7.Value) * Manga);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown7.Value == 0)
                    {
                        vmanga = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }
        }
        
        /* numerick up down da bebidas */
        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                if (numericUpDown8.Value >= 1)
                {
                    vcabernetsauvagnon = (Convert.ToInt32(numericUpDown8.Value) * CabernetSauvagnon);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown8.Value == 0)
                    {
                        vcabernetsauvagnon = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                if (numericUpDown9.Value >= 1)
                {
                    vcabernetfranc = (Convert.ToInt32(numericUpDown9.Value) * CabernetFranc);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown9.Value == 0)
                    {
                        vcabernetfranc = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                if (numericUpDown10.Value >= 1)
                {
                    vtannat = (Convert.ToInt32(numericUpDown10.Value) * Tannat);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown10.Value == 0)
                    {
                        vtannat = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }

        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                if (numericUpDown11.Value >= 1)
                {
                    vmerlot = (Convert.ToInt32(numericUpDown11.Value) * Merlot);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown11.Value == 0)
                    {
                        vmerlot = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                if (numericUpDown12.Value >= 1)
                {
                    vmalbec = (Convert.ToInt32(numericUpDown12.Value) * Malbec);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown12.Value == 0)
                    {
                        vmalbec= 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                if (numericUpDown13.Value >= 1)
                {
                    vrisling = (Convert.ToInt32(numericUpDown13.Value) * Risling);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown13.Value == 0)
                    {
                        vrisling = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }
        }

        /* numerick up down dos doces*/
        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                if (numericUpDown14.Value >= 1)
                {
                    vpirulito = (Convert.ToInt32(numericUpDown14.Value) * Pirulito);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown14.Value == 0)
                    {
                        vpirulito = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }
        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                if (numericUpDown15.Value >= 1)
                {
                    vbolachasuspiro = (Convert.ToInt32(numericUpDown15.Value) * BolachaSuspiro);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown15.Value == 0)
                    {
                        vbolachasuspiro = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }
        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                if (numericUpDown16.Value >= 1)
                {
                    vcanudodoce = (Convert.ToInt32(numericUpDown16.Value) * CanudoDoce);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown16.Value == 0)
                    {
                        vcanudodoce = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }
        }

        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                if (numericUpDown17.Value >= 1)
                {
                    vpastadeamendoim = (Convert.ToInt32(numericUpDown17.Value) * PastaDeAmendoim);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown17.Value == 0)
                    {
                        vpastadeamendoim = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }
        }

        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
            {
                if (numericUpDown18.Value >= 1)
                {
                    vbiscoitodechococlate = (Convert.ToInt32(numericUpDown18.Value) * BiscoitoDeChocolate);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown18.Value == 0)
                    {
                        vbiscoitodechococlate = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }
        }

        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                if (numericUpDown19.Value >= 1)
                {
                    vchocolateaoleite = (Convert.ToInt32(numericUpDown19.Value) * ChocolateAoLeite);
                    total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                    vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                    vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                    vbiscoitodechococlate + vchocolateaoleite;

                    label8.Text = ("R$" + total + ",00");

                }
                else
                {
                    if (numericUpDown19.Value == 0)
                    {
                        vchocolateaoleite = 0;
                        total = vbanana + vmaça + vabacaxi + vlaranja + vkiwi + vcachodeuva + vmanga +
                        vcabernetsauvagnon + vcabernetfranc + vtannat + vmerlot + vmalbec +
                        vrisling + vpirulito + vbolachasuspiro + vcanudodoce + vpastadeamendoim +
                        vbiscoitodechococlate + vchocolateaoleite;
                    }
                    label8.Text = ("R$" + total + ",00");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (total >= 0)
            {
                if (MessageBox.Show("deseja comprar a cesta personalizada?",
                "informação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    MessageBox.Show("Obrigado por comprar!!!");
                    
                    this.Close();
                }


            }
        }
    }
}
