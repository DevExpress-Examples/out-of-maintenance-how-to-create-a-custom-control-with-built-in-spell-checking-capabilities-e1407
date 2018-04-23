using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using DevExpress.XtraSpellChecker;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Drawing;


namespace CustomControl {
    class MyMemoEdit : DevExpress.XtraEditors.MemoEdit {

                protected SpellChecker myMemoSpellChecker = new SpellChecker();

        public MyMemoEdit() : base()
        {
            InitializeSpellChecker(this, myMemoSpellChecker);

        }

         
        public void InitializeSpellChecker (Control control, SpellChecker spellChecker) {
            CultureInfo usCulture = new CultureInfo("en-US");
            spellChecker.Culture = usCulture;
            SharedDictionaryStorage sharedDictionaryStorage = new SharedDictionaryStorage();

            SpellCheckerOpenOfficeDictionary dictionary = new SpellCheckerOpenOfficeDictionary("en_US.dic", "en_US.aff", usCulture);
            sharedDictionaryStorage.Dictionaries.Add(dictionary);
            SpellCheckerCustomDictionary customDictionary = new SpellCheckerCustomDictionary("custom_US.dic", usCulture);
            sharedDictionaryStorage.Dictionaries.Add(customDictionary);
            spellChecker.UseSharedDictionaries = true;

            OptionsSpelling options = new OptionsSpelling();
            options.IgnoreRepeatedWords = DevExpress.Utils.DefaultBoolean.False;
            options.IgnoreMixedCaseWords = DevExpress.Utils.DefaultBoolean.False;
            spellChecker.SetSpellCheckerOptions(control, options);
            spellChecker.SpellCheckMode = SpellCheckMode.AsYouType;        

            spellChecker.CheckAsYouTypeOptions.CheckControlsInParentContainer = true;
            spellChecker.ParentContainer = control;
            spellChecker.SetCanCheckText(control, true);
        
        }


    }
}
