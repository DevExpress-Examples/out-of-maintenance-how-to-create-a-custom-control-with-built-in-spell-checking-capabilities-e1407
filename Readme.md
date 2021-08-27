<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1407)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomMemoEditControl/Form1.cs) (VB: [Form1.vb](./VB/CustomMemoEditControl/Form1.vb))
* [MyMemoEdit.cs](./CS/CustomMemoEditControl/MyMemoEdit.cs) (VB: [MyMemoEdit.vb](./VB/CustomMemoEditControl/MyMemoEdit.vb))
<!-- default file list end -->
# How to create a custom control with built-in spell checking capabilities


<p>This example implements a custom control derived from the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsMemoEdittopic">MemoEdit</a> class. The XtraSpellChecker is instantiated and initialized at runtime when the control is created.<br />
This technique enables you to provide specific spelling capabilities for a particular control.<br />
Note that the registration procedure is called before the controls on the form are initialized, to notify the SpellChecker that it should check objects of the custom class.  It also defines the rules which the SpellChecker will follow when working with this editor.</p>

<br/>


