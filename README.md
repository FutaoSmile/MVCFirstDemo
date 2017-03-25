# MVCFirstDemo

## Asp.net MVC 学习之路

实现了增删改查，按条件查等操作

[在简书上写的EntityFramework笔记](http://www.jianshu.com/nb/10166743)

[在简书上写的asp.net MVC笔记](http://www.jianshu.com/nb/10595168)

 ** 各项目之间的关系：** 

MovieEF项目运用EntityFramework-CodeFirst模式设计实体并编写上下文。
Movies项目为一个asp.net mvc项目，引用MovieEF的实体进行数据展示等操作。
MvcFirstDemo为一个独立的项目，实体在model文件夹按EntityFramework的modelFirst模式实现。
WebApi同样引用了MovieEF的实体，并调用了一个图灵机器人的接口。
