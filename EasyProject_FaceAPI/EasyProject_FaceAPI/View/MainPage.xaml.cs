using System;
using Xamarin.Forms;

// [assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace EasyProject_FaceAPI.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            Device.OnPlatform(
                WinPhone: () => 
                {
                    displayImage.HeightRequest = 500;
                    displayImage.WidthRequest = 500;
                });
        }

        private async void dectedBtn_Clicked(object sender, EventArgs e)
        {
            // TODO: 4. 利用剛才建立的 DetectedFace() 方法取得辨識資訊，並顯示辨識後的圖片
                // Step 1: 新增一個 FaceFunction 類別的物件並使用 DectedFace() 方法 (回傳一個 MyDataType 型別的物件)
                // Step 2: 指定 MyDataType 型別物件中的 ImageUri 屬性為照片的 URI
                // Step 3: 建立 Draw 類別的物件，使用 GetDrawedImage(MyDataType) 取回被辨識的圖片 (以 Base64 編碼)
                // Step 4: 使用 Draw 的 GetStream(string) 方法，將以 Base64 編碼的圖片轉換成 Stream 類別的物件
                // Step 5: 指定 displayImage 這個控制項的圖片來源 (利用 ImageSource.FromStream(fun<Stream> stream))   
                
            displayImage.Source = ImageSource.FromUri(Constant.ImageUri);                 
        }
    }
}
