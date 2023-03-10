using System.Collections.ObjectModel;

namespace ListViewSelectedItemColorBug;


public class TestConfig
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

public partial class MainPage : ContentPage
{
    private ObservableCollection<TestConfig> mytestconfiglist;

    public ObservableCollection<TestConfig> TestConfigList
    {
        get { return mytestconfiglist; }
        set { mytestconfiglist = value; }
    }

    public MainPage()
	{
        TestConfigList = new ObservableCollection<TestConfig>();

        for (int i = 1; i < 10; i++)
        {
            TestConfigList.Add(new TestConfig() { Name = "Item" + i.ToString() });
        }

        InitializeComponent();

        this.BindingContext = this;
    }
}

