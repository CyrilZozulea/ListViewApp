using ListViewApp.Cache_Date;

namespace ListViewApp.Page;

public partial class App : Application
{
    private static Cache cache;

    public static Cache Cache
    {
        get
        {
            if (cache == null)
            {
                cache = new Cache(Path
                    .Combine(Environment
                    .GetFolderPath(Environment
                    .SpecialFolder.LocalApplicationData), "cash.db3"));
            }

            return cache;
        }
    }

    public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new TopicList());
	}
}