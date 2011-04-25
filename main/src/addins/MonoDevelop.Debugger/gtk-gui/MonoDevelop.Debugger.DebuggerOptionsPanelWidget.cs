
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Debugger
{
	public partial class DebuggerOptionsPanelWidget
	{
		private global::Gtk.Notebook notebook1;

		private global::Gtk.VBox vbox3;

		private global::Gtk.CheckButton projectCodeOnly;

		private global::Gtk.CheckButton checkAllowEval;

		private global::Gtk.CheckButton checkToString;

		private global::Gtk.CheckButton checkShowBaseGroup;

		private global::Gtk.CheckButton checkGroupPrivate;

		private global::Gtk.CheckButton checkGroupStatic;

		private global::Gtk.Table tableEval;

		private global::Gtk.Label label60;

		private global::Gtk.SpinButton spinTimeout;

		private global::Gtk.Label label4;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label2;

		private global::MonoDevelop.Ide.Gui.Components.PriorityList prioritylist;

		private global::Gtk.Label label1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Debugger.DebuggerOptionsPanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.Debugger.DebuggerOptionsPanelWidget";
			// Container child MonoDevelop.Debugger.DebuggerOptionsPanelWidget.Gtk.Container+ContainerChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 1;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			this.vbox3.BorderWidth = ((uint)(9));
			// Container child vbox3.Gtk.Box+BoxChild
			this.projectCodeOnly = new global::Gtk.CheckButton ();
			this.projectCodeOnly.CanFocus = true;
			this.projectCodeOnly.Name = "projectCodeOnly";
			this.projectCodeOnly.Label = global::Mono.Unix.Catalog.GetString ("Debug project code only; do not step into framework code.");
			this.projectCodeOnly.Active = true;
			this.projectCodeOnly.DrawIndicator = true;
			this.projectCodeOnly.UseUnderline = true;
			this.vbox3.Add (this.projectCodeOnly);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.projectCodeOnly]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.checkAllowEval = new global::Gtk.CheckButton ();
			this.checkAllowEval.CanFocus = true;
			this.checkAllowEval.Name = "checkAllowEval";
			this.checkAllowEval.Label = global::Mono.Unix.Catalog.GetString ("Allow implicit property evaluation and method invocation");
			this.checkAllowEval.Active = true;
			this.checkAllowEval.DrawIndicator = true;
			this.checkAllowEval.UseUnderline = true;
			this.vbox3.Add (this.checkAllowEval);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.checkAllowEval]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.checkToString = new global::Gtk.CheckButton ();
			this.checkToString.CanFocus = true;
			this.checkToString.Name = "checkToString";
			this.checkToString.Label = global::Mono.Unix.Catalog.GetString ("Use ToString() to get the string value of objects");
			this.checkToString.DrawIndicator = true;
			this.checkToString.UseUnderline = true;
			this.vbox3.Add (this.checkToString);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.checkToString]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.checkShowBaseGroup = new global::Gtk.CheckButton ();
			this.checkShowBaseGroup.CanFocus = true;
			this.checkShowBaseGroup.Name = "checkShowBaseGroup";
			this.checkShowBaseGroup.Label = global::Mono.Unix.Catalog.GetString ("Shown inherited class members in a base class group");
			this.checkShowBaseGroup.DrawIndicator = true;
			this.checkShowBaseGroup.UseUnderline = true;
			this.vbox3.Add (this.checkShowBaseGroup);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.checkShowBaseGroup]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.checkGroupPrivate = new global::Gtk.CheckButton ();
			this.checkGroupPrivate.CanFocus = true;
			this.checkGroupPrivate.Name = "checkGroupPrivate";
			this.checkGroupPrivate.Label = global::Mono.Unix.Catalog.GetString ("Group non-public members");
			this.checkGroupPrivate.DrawIndicator = true;
			this.checkGroupPrivate.UseUnderline = true;
			this.vbox3.Add (this.checkGroupPrivate);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.checkGroupPrivate]));
			w5.Position = 4;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.checkGroupStatic = new global::Gtk.CheckButton ();
			this.checkGroupStatic.CanFocus = true;
			this.checkGroupStatic.Name = "checkGroupStatic";
			this.checkGroupStatic.Label = global::Mono.Unix.Catalog.GetString ("Group static members");
			this.checkGroupStatic.DrawIndicator = true;
			this.checkGroupStatic.UseUnderline = true;
			this.vbox3.Add (this.checkGroupStatic);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.checkGroupStatic]));
			w6.Position = 5;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.tableEval = new global::Gtk.Table (((uint)(1)), ((uint)(3)), false);
			this.tableEval.Name = "tableEval";
			this.tableEval.RowSpacing = ((uint)(6));
			this.tableEval.ColumnSpacing = ((uint)(6));
			// Container child tableEval.Gtk.Table+TableChild
			this.label60 = new global::Gtk.Label ();
			this.label60.Name = "label60";
			this.label60.Xalign = 0f;
			this.label60.LabelProp = global::Mono.Unix.Catalog.GetString ("Evaluation Timeout:");
			this.tableEval.Add (this.label60);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.tableEval[this.label60]));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableEval.Gtk.Table+TableChild
			this.spinTimeout = new global::Gtk.SpinButton (0, 1000000, 100);
			this.spinTimeout.CanFocus = true;
			this.spinTimeout.Name = "spinTimeout";
			this.spinTimeout.Adjustment.PageIncrement = 10;
			this.spinTimeout.ClimbRate = 100;
			this.spinTimeout.Numeric = true;
			this.tableEval.Add (this.spinTimeout);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.tableEval[this.spinTimeout]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.tableEval);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.tableEval]));
			w9.Position = 6;
			w9.Expand = false;
			w9.Fill = false;
			this.notebook1.Add (this.vbox3);
			// Notebook tab
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("General");
			this.notebook1.SetTabLabel (this.vbox3, this.label4);
			this.label4.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.WidthRequest = 417;
			this.label2.Name = "label2";
			this.label2.Xalign = 0f;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("This priority list will be used by MonoDevelop when selecting the engine to be used for debugging an application.");
			this.label2.Wrap = true;
			this.vbox2.Add (this.label2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label2]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.prioritylist = new global::MonoDevelop.Ide.Gui.Components.PriorityList ();
			this.prioritylist.Name = "prioritylist";
			this.vbox2.Add (this.prioritylist);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.prioritylist]));
			w12.Position = 1;
			this.notebook1.Add (this.vbox2);
			global::Gtk.Notebook.NotebookChild w13 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.vbox2]));
			w13.Position = 1;
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Preferred Debuggers");
			this.notebook1.SetTabLabel (this.vbox2, this.label1);
			this.label1.ShowAll ();
			this.Add (this.notebook1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.checkAllowEval.Toggled += new global::System.EventHandler (this.OnCheckAllowEvalToggled);
		}
	}
}
