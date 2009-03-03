// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.UIManager UIManager;
    
    private Gtk.Action connectAction;
    
    private Gtk.ToggleAction SSLAction;
    
    private Gtk.Action quitAction;
    
    private Gtk.VBox vbox1;
    
    private Gtk.Toolbar toolbar1;
    
    private Gtk.HBox hbox1;
    
    private Gtk.Label label1;
    
    private Gtk.Entry xid;
    
    private Gtk.HBox hbox2;
    
    private Gtk.Label label2;
    
    private Gtk.Entry password;
    
    private Gtk.Statusbar statusbar1;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        this.UIManager = new Gtk.UIManager();
        Gtk.ActionGroup w1 = new Gtk.ActionGroup("Default");
        this.connectAction = new Gtk.Action("connectAction", null, Mono.Unix.Catalog.GetString("Connect to server"), "gtk-connect");
        w1.Add(this.connectAction, null);
        this.SSLAction = new Gtk.ToggleAction("SSLAction", Mono.Unix.Catalog.GetString("SSL"), Mono.Unix.Catalog.GetString("Enable SSL for connection"), "gtk-dialog-authentication");
        this.SSLAction.ShortLabel = Mono.Unix.Catalog.GetString("SSL");
        w1.Add(this.SSLAction, null);
        this.quitAction = new Gtk.Action("quitAction", null, null, "gtk-quit");
        w1.Add(this.quitAction, null);
        this.UIManager.InsertActionGroup(w1, 0);
        this.AddAccelGroup(this.UIManager.AccelGroup);
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("Login");
        this.WindowPosition = ((Gtk.WindowPosition)(4));
        this.Modal = true;
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.vbox1 = new Gtk.VBox();
        this.vbox1.Name = "vbox1";
        this.vbox1.Spacing = 6;
        // Container child vbox1.Gtk.Box+BoxChild
        this.UIManager.AddUiFromString("<ui><toolbar name='toolbar1'><toolitem name='connectAction' action='connectAction'/><toolitem name='SSLAction' action='SSLAction'/><toolitem name='quitAction' action='quitAction'/></toolbar></ui>");
        this.toolbar1 = ((Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
        this.toolbar1.Name = "toolbar1";
        this.toolbar1.ShowArrow = false;
        this.toolbar1.ToolbarStyle = ((Gtk.ToolbarStyle)(0));
        this.vbox1.Add(this.toolbar1);
        Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.toolbar1]));
        w2.Position = 0;
        w2.Expand = false;
        w2.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hbox1 = new Gtk.HBox();
        this.hbox1.Name = "hbox1";
        this.hbox1.Spacing = 6;
        // Container child hbox1.Gtk.Box+BoxChild
        this.label1 = new Gtk.Label();
        this.label1.Name = "label1";
        this.label1.LabelProp = Mono.Unix.Catalog.GetString("Username");
        this.hbox1.Add(this.label1);
        Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.label1]));
        w3.Position = 0;
        w3.Expand = false;
        w3.Fill = false;
        // Container child hbox1.Gtk.Box+BoxChild
        this.xid = new Gtk.Entry();
        this.xid.CanFocus = true;
        this.xid.Name = "xid";
        this.xid.IsEditable = true;
        this.xid.InvisibleChar = '●';
        this.hbox1.Add(this.xid);
        Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox1[this.xid]));
        w4.Position = 1;
        this.vbox1.Add(this.hbox1);
        Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
        w5.Position = 1;
        w5.Expand = false;
        w5.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hbox2 = new Gtk.HBox();
        this.hbox2.Name = "hbox2";
        this.hbox2.Spacing = 6;
        // Container child hbox2.Gtk.Box+BoxChild
        this.label2 = new Gtk.Label();
        this.label2.Name = "label2";
        this.label2.LabelProp = Mono.Unix.Catalog.GetString("Password");
        this.hbox2.Add(this.label2);
        Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox2[this.label2]));
        w6.Position = 0;
        w6.Expand = false;
        w6.Fill = false;
        // Container child hbox2.Gtk.Box+BoxChild
        this.password = new Gtk.Entry();
        this.password.CanFocus = true;
        this.password.Name = "password";
        this.password.IsEditable = true;
        this.password.InvisibleChar = '●';
        this.hbox2.Add(this.password);
        Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox2[this.password]));
        w7.Position = 1;
        this.vbox1.Add(this.hbox2);
        Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
        w8.Position = 2;
        w8.Expand = false;
        w8.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.statusbar1 = new Gtk.Statusbar();
        this.statusbar1.Name = "statusbar1";
        this.statusbar1.Spacing = 6;
        this.vbox1.Add(this.statusbar1);
        Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox1[this.statusbar1]));
        w9.Position = 3;
        w9.Expand = false;
        w9.Fill = false;
        this.Add(this.vbox1);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 400;
        this.DefaultHeight = 162;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        this.connectAction.Activated += new System.EventHandler(this.OnConnect);
        this.SSLAction.Toggled += new System.EventHandler(this.OnSSL);
        this.quitAction.Activated += new System.EventHandler(this.OnQuit);
    }
}
