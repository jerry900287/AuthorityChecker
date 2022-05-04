# AuthorityChecker

## User Interface Privilege Isolation (UAC)
使用者介面特權隔離（User Interface Privilege Isolation），是 Windows 7 通過 MIC 機制新引入的一種安全特性，用於攔截接收比自身程序 MIC 等級低的程序發來的訊息。UIPI 的目的是為了規範不同程序視窗之間的視窗訊息處理過程，預設情況下，高許可權程序不會接收到低許可權程序傳送的視窗訊息的，但是低許可權程序能夠接收到高許可權程序的視窗訊息。UIPI 的本質是系統檢查目標視窗和傳送方是否具有相同的 MIC 等級或者傳送方具有更高的 MIC 等級，如果符合上述條件，則允許訊息的傳遞，否則將訊息丟棄。
因此，在 Windows 7 作業系統中執行的使用者程序，如果執行時具有不同的完整性等級，即具有不同的 MIC 等級，那麼相互間的通訊將會無法像 Windows XP 那樣正常進行。

## requestedExecutionLevel  

1. asInvoker : 如果選這個，應用程式就是以當前的許可權執行。
2. highestAvailable: 這個是以當前使用者可以獲得的最高許可權執行。
3. requireAdministrator: 這個是僅以系統管理員許可權執行。

highestAvailable 和 requireAdministrator 的區別在於，如果我們不是以管理員帳號登入，那麼如果應用程式設定為 requireAdministrator ，那麼應用程式就直接執行失敗，無法啟動。而如果設定為 highestAvailable,則應用程式可以執行成功，但是是以當前帳號的許可權執行而不是系統管理員許可權執行。如果我們希望程式在非管理員帳號登入時也可以執行（這種情況下應該某些功能受限制) ，那麼建議採用 highestAvailable 來配置。

## Reference

* [WindowsBuiltInRole 列舉](https://docs.microsoft.com/zh-tw/dotnet/api/system.security.principal.windowsbuiltinrole?view=net-6.0)
* [Check for administrator privileges in C#](https://stackoverflow.com/questions/5953240/check-for-administrator-privileges-in-c-sharp)
* [C#預設以管理員身份執行程式](https://www.796t.com/content/1547843602.html)
* [应用程序清单 Manifest 中各种 UAC 权限级别的含义和效果](https://blog.walterlv.com/post/requested-execution-level-of-application-manifest.html)
* [如何在 Windows 11 中關閉 使用者帳戶控制功能（UAC）](https://walker-a.com/archives/6970#:~:text=%E4%B8%80%E8%88%AC%E4%BE%86%E8%AA%AA%EF%BC%8C%E4%BD%BF%E7%94%A8%E8%80%85,%E9%80%99%E6%98%AF%E9%9D%9E%E5%B8%B8%E5%8D%B1%E9%9A%AA%E7%9A%84%E3%80%82)
* https://docs.microsoft.com/zh-tw/cpp/build/reference/manifestuac-embeds-uac-information-in-manifest?view=msvc-170
* https://stackoverflow.com/questions/42375096/what-is-requestedexecutionlevel-level-asinvoker-uiaccess-true
* https://www.796t.com/article.php?id=34604
* https://dotblogs.com.tw/supershowwei/2016/01/26/175448