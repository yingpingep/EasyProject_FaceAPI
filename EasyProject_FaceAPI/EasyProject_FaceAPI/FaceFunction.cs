using DrawFunction;
using Microsoft.ProjectOxford.Face;
using System.Threading.Tasks;

namespace EasyProject_FaceAPI
{
    class FaceFunction
    {
        // TODO: 1. 利用 FaceServiceClient 連線至 Cognitive service，並建立相關方法
        // Step 1: new FaceServiceClient("Your key")

        public async Task<MyDataType> DectedFace()
        {
            // 設定 FaceAttributeType 屬性的陣列，可以選擇要回傳哪些屬性 
            FaceAttributeType[] fats = new FaceAttributeType[]
            {
                FaceAttributeType.Age
            };

            // TODO: 2. 使用 FaceServiceClient 提供的 DetectAsync 方法取得已辨識的臉部資訊
            // Step 1: FaceServiceClient.DetectAsync(string, ...)      
            FaceServiceClient fsc = new FaceServiceClient(Constant.FaceKey);
            var faces = fsc.DetectAsync(Constant.ImageUri.ToString(), true, false, fats);        

            // TODO: 3. 建立 MyDataType 型別的物件，整理 FaceServiceClient 傳回的資訊，方便後續使用
            // Step 1: new MyDataType();
            // Step 2: foreach (faces)
            // Step 3: rects.Add(new Rect(int, int, int))
            // Step 4: ages.Add(new Age(FaceAttributes.Age))         
               

            return new MyDataType();
        }
    }
}
