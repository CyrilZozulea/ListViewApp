using ListViewApp.Model;

namespace ListViewApp.Page;

public partial class QuestionList : ContentPage
{
    private object topicData;
    public QuestionList(object item)
    {
        this.topicData = item;

        InitializeComponent();

        var questionView = new ListView
        {
            ItemsSource = new QuestionListModel(item).Source,
            ItemTemplate = new DataTemplate(() =>
            {
                return GetQuestionContent();
            }),
            SeparatorColor = Colors.Cyan,
            RefreshControlColor = Colors.DarkGrey
        };
        questionView.ItemSelected += OnSelectItem;

        Content = questionView;
    }

    async void OnSelectItem(object item, EventArgs args)
    {
        if (((ListView)item).SelectedItem != null)
        {
            await Navigation.PushAsync(new RaplyList(item, topicData));
        }
    }

    public TextCell GetQuestionContent()
    {
        var question = new TextCell
        {
            TextColor = Colors.Crimson,
        };

        question.SetBinding(TextCell.TextProperty, new Binding(nameof(QuestionModel.Name)));

        return question;
    }
}