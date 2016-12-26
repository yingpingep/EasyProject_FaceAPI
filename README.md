# Easy Project - Face API 的使用

## 說明：
這一個 Easy Project 會指導大家如何透過 *Face API Client* 來連線至 Cognitive Source 取得臉部資訊  
再將這些資訊上傳至預先建立好的 Web Service 將臉部標示出來  
最後在 UI 控制項顯示後製過的圖片

## TODO: Prepare. 事前準備
``` c#
public static string FaceKey = "Your Key";
// public static Uri ImageUri = new Uri("http://i.imgur.com/lfP6evD.jpg");
public static Uri ImageUri = new Uri("https://scontent-tpe1-1.xx.fbcdn.net/v/t31.0-8/10847765_987795661235969_5085961470711725489_o.jpg?oh=e8b2619b740083ad50b0d511c6b4df0c&oe=58DC134D");
```

## TODO: 1. 利用 FaceServiceClient 連線至 Cognitive service，並建立相關方法
``` c#
FaceServiceClient fsc = new FaceServiceClient(Constant.FaceKey);
```

## TODO: 2. 使用 FaceServiceClient 提供的 DetectAsync 方法取得已辨識的臉部資訊
``` c#
var faces = await fsc.DetectAsync(Constant.ImageUri.ToString(), true, false, fats);
```

## TODO: 3. 建立 MyDataType 型別的物件，整理 FaceServiceClient 傳回的資訊，方便後續使用
``` c#
MyDataType mydata = new MyDataType();
foreach (var item in faces)
{
    mydata.rects.Add(new Rect(item.FaceRectangle.Left, 
                            item.FaceRectangle.Top, 
                            item.FaceRectangle.Width));

    mydata.ages.Add(new Age(item.FaceAttributes.Age));
}
```

## TODO: 4. 利用剛才建立的 DetectedFace() 方法取得辨識資訊，並顯示辨識後的圖片
``` c#
FaceFunction facefunction = new FaceFunction();
MyDataType mydata = await facefunction.DectedFace();
mydata.imageuri = Constant.ImageUri.ToString();
Draw drawfunction = new Draw();

string ss = await drawfunction.GetDrawedImage(mydata);
displayImage.Source = ImageSource.FromStream(() => drawfunction.GetStream(ss));
```