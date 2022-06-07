using ListViewApp.Model;

namespace ListViewApp.Page;

public partial class RaplyList : ContentPage
{
    private string RadioButtonContent;
    private string CheckBoxContent = null;
    private QuestionModel questionData;
    private TopicModel topicData;
    public RaplyList(object questionData, object topicData)
    {

        InitializeComponent();

        var questionModel = (QuestionModel)((ListView)questionData).SelectedItem;
        this.questionData = questionModel;

        var topicModel = (TopicModel)((ListView)topicData).SelectedItem;
        this.topicData = topicModel;

        Question.Text = questionModel.Name;
    }

    async void OnClickEvent(object item, EventArgs args)
    {
        try
        {
            var accessType = Connectivity.Current.NetworkAccess;

            if (accessType == NetworkAccess.Internet)
            {
                App.Cache.DeleteAllCache();
                await DisplayAlert("Wifi on", "Your choose send to database", "OK");
            }
            else
            {
                var model = new Individual_Chooses
                {
                    TopicID = topicData.ID,
                    QuestinID = questionData.ID,
                    Text = StringContent.Text,
                    Number = IntegerContent.Text,
                    RadioButtonChoose = RadioButtonContent,
                    ChackBoxChoose = CheckBoxContent,
                };

                await App.Cache.SaveCache(model);
                await DisplayAlert("Wifi off", "Your choose save to the mobile cache", "OK");
            }

            Content = null;
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Message: {ex.Message}", "OK");
        }
    }

    void RadioButton(object item, EventArgs args)
    {
        RadioButtonContent = (string)((RadioButton)item).Content;
    }

    void FirstCheckBox(object item, EventArgs args)
    {
        CheckBoxContent += "Q_1_Q, ";
    }

    void SecondCheckBox(object item, EventArgs args)
    {
        CheckBoxContent += "Q_2_Q, ";
    }

    async void OnGet(object item, EventArgs args)
    {
        try
        {
            var Model = await App.Cache.GetCache(topicData.ID, questionData.ID);

            StringContent.Text = Model.Text;
            IntegerContent.Text = Model.Number;

            if (Model.RadioButtonChoose.Contains("1"))
                btn1.IsChecked = true;
            if (Model.RadioButtonChoose.Contains("2"))
                btn2.IsChecked = true;
            if (Model.RadioButtonChoose.Contains("3"))
                btn3.IsChecked = true;
            if (Model.RadioButtonChoose.Contains("4"))
                btn4.IsChecked = true; 
            
            if (Model.ChackBoxChoose.Contains("1"))
                box1.IsChecked = true;
            if (Model.ChackBoxChoose.Contains("2"))
                box2.IsChecked = true;
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Message: {ex.Message}", "OK");
        }
    }
}