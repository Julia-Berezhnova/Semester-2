
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Table table1;
	
	private global::Gtk.Label timeLabel;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("ClockWidget");
		this.WindowPosition = ((global::Gtk.WindowPosition)(2));
		this.Resizable = false;
		this.AllowGrow = false;
		this.DefaultWidth = 500;
		this.DefaultHeight = 400;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.table1 = new global::Gtk.Table (((uint)(1)), ((uint)(1)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.timeLabel = new global::Gtk.Label ();
		this.timeLabel.Name = "timeLabel";
		this.table1.Add (this.timeLabel);
		this.Add (this.table1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
