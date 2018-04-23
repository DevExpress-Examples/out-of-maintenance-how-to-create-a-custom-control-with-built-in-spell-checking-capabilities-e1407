using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomControl {
    public partial class Form1 : Form {
        public Form1() {
            DevExpress.XtraSpellChecker.Native.SpellCheckTextControllersManager.Default.RegisterClass(typeof(CustomControl.MyMemoEdit), typeof(DevExpress.XtraSpellChecker.Native.SimpleTextEditTextController));
            DevExpress.XtraSpellChecker.Native.SpellCheckTextBoxBaseFinderManager.Default.RegisterClass(typeof(CustomControl.MyMemoEdit), typeof(DevExpress.XtraSpellChecker.Native.MemoEditTextBoxFinder));

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            myMemoEdit1.Text = "The quik onyx gobleen jumps over the laizy dvarf";
            myMemoEdit1.DeselectAll();

            memoEdit1.Text = "The quik onyx gobleen jumps over the laizy dvarf";
        }


    }
}