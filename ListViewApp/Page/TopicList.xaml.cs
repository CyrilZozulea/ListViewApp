using ListViewApp.Model;

namespace ListViewApp.Page;

public partial class TopicList : ContentPage
{
    public TopicList()
    {
        InitializeComponent();

        var topicView = new ListView
        {
            ItemsSource = new TopicListModel().Source,
            ItemTemplate = new DataTemplate(() =>
            {
                return GetTopicContent();
            }),
            SeparatorColor = Colors.Cyan,
            RefreshControlColor = Colors.DarkGrey,
            SelectionMode = ListViewSelectionMode.Single
        };
        topicView.ItemSelected += OnSelectItem;

        Content = topicView;
    }

    async void OnSelectItem(object item, EventArgs args)
    {
        try
        {
            if (((ListView)item).SelectedItem != null)
            {
                await Navigation.PushAsync(new QuestionList(item));
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Message - {ex.Message}", "OK");
        }
    }

    public TextCell GetTopicContent()
    {
        var topic = new TextCell
        {
            TextColor = Colors.Crimson
        };

        topic.SetBinding(TextCell.TextProperty, new Binding(nameof(TopicModel.Name)));

        return topic;
    }
}