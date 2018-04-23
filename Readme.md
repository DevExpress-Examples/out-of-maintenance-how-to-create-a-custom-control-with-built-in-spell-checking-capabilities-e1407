# How to create a custom control with built-in spell checking capabilities


<p>This example implements a custom control derived from the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsMemoEdittopic">MemoEdit</a> class. The XtraSpellChecker is instantiated and initialized at runtime when the control is created.<br />
This technique enables you to provide specific spelling capabilities for a particular control.<br />
Note that the registration procedure is called before the controls on the form are initialized, to notify the SpellChecker that it should check objects of the custom class.  It also defines the rules which the SpellChecker will follow when working with this editor.</p>

<br/>


