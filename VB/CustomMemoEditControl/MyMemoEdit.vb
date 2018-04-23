Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Globalization
Imports DevExpress.XtraSpellChecker
Imports System.Windows.Forms
Imports System.ComponentModel.Design
Imports System.Drawing


Namespace CustomControl
	Friend Class MyMemoEdit
		Inherits DevExpress.XtraEditors.MemoEdit

				Protected myMemoSpellChecker As New SpellChecker()

		Public Sub New()
			MyBase.New()
			InitializeSpellChecker(Me, myMemoSpellChecker)

		End Sub


		Public Sub InitializeSpellChecker(ByVal control As Control, ByVal spellChecker As SpellChecker)
			Dim usCulture As New CultureInfo("en-US")
			spellChecker.Culture = usCulture
			Dim sharedDictionaryStorage As New SharedDictionaryStorage()

			Dim dictionary As New SpellCheckerOpenOfficeDictionary("en_US.dic", "en_US.aff", usCulture)
			sharedDictionaryStorage.Dictionaries.Add(dictionary)
			Dim customDictionary As New SpellCheckerCustomDictionary("custom_US.dic", usCulture)
			sharedDictionaryStorage.Dictionaries.Add(customDictionary)
			spellChecker.UseSharedDictionaries = True

			Dim options As New OptionsSpelling()
			options.IgnoreRepeatedWords = DevExpress.Utils.DefaultBoolean.False
			options.IgnoreMixedCaseWords = DevExpress.Utils.DefaultBoolean.False
			spellChecker.SetSpellCheckerOptions(control, options)
			spellChecker.SpellCheckMode = SpellCheckMode.AsYouType

			spellChecker.CheckAsYouTypeOptions.CheckControlsInParentContainer = True
			spellChecker.ParentContainer = control
			spellChecker.SetCanCheckText(control, True)

		End Sub


	End Class
End Namespace
