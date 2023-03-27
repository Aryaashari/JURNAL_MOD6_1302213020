using Modul6_1302213020;

SayaTubeUser user = new SayaTubeUser("Arya");

SayaTubeVideo video1 = new SayaTubeVideo("Review Film AAA oleh Arya");
SayaTubeVideo video2 = new SayaTubeVideo("Review Film BBB oleh Arya");
SayaTubeVideo video3 = new SayaTubeVideo("Review Film CCC oleh Arya");
SayaTubeVideo video4 = new SayaTubeVideo("Review Film DDD oleh Arya");
SayaTubeVideo video5 = new SayaTubeVideo("Review Film EEE oleh Arya");
SayaTubeVideo video6 = new SayaTubeVideo("Review Film FFF oleh Arya");
SayaTubeVideo video7 = new SayaTubeVideo("Review Film GGG oleh Arya");
SayaTubeVideo video8 = new SayaTubeVideo("Review Film HHH oleh Arya");
SayaTubeVideo video9 = new SayaTubeVideo("Review Film III oleh Arya");
SayaTubeVideo video10 = new SayaTubeVideo("Review Film JJJ oleh Arya");


user.AddVideo(video1);
user.AddVideo(video2);
user.AddVideo(video3);
user.AddVideo(video4);
user.AddVideo(video5);
user.AddVideo(video6);
user.AddVideo(video7);
user.AddVideo(video8);
user.AddVideo(video9);
user.AddVideo(video10);

user.PrintAllVideoPlayCount();