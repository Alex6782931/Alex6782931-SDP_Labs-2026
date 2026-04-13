using Lab1.Lab1Folder;
using Lab2;
using Lab3;
using Lab3.Lab4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class frmLab3D : Form
    {
        public frmLab3D()
        {
            InitializeComponent();
        }

        private void frmLab3D_Load(object sender, EventArgs e)
        {
            cboLabs.Items.Add("Lab 1");
            cboLabs.Items.Add("Lab 2A");
            cboLabs.Items.Add("Lab 2B");
            cboLabs.Items.Add("Lab 2C");
            cboLabs.Items.Add("Lab 3A");
            cboLabs.Items.Add("Lab 3B");
            cboLabs.Items.Add("Lab 3C");
            cboLabs.Items.Add("Lab 4");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            switch (cboLabs.SelectedItem) 
            { 
            case "Lab 1":
                frmLab1 Lab1 = new frmLab1();
                Lab1.ShowDialog();
                break;
            case "Lab2A":
                frmLab2A Lab2a = new frmLab2A();
                Lab2a.ShowDialog();
                break;
                case "Lab 2B":
                frmLab2B Lab2b = new frmLab2B();
                Lab2b.ShowDialog();
                    break;
                case "Lab 2C":
                    frmLab2C Lab2c = new frmLab2C();
                    Lab2c.ShowDialog();
                    break;
                case "Lab 3A":
                    frmLab3A Lab3a = new frmLab3A();
                    Lab3a.ShowDialog();
                    break;
                case "Lab 3B":
                    frmLab3B Lab3b = new frmLab3B();
                    Lab3b.ShowDialog(); break;
                    break;
                case "Lab 3C":
                    frmLab3C Lab3c = new frmLab3C();
                    Lab3c.ShowDialog();
                    break;
                case "Lab 4":
                    frmLab4 Lab4 = new frmLab4();
                    Lab4.ShowDialog();
                    break;
            default:
                MessageBox.Show("Please select a lab from the dropdown.");
                break;
            }
        }
    } 
}
