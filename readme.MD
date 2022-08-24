# JuJuBot
.Net Core 3.1 MVC 專案 測試 Three.js

透過 ElectronNET 建置成 desktop application

## 棄用原因 
- electronize 編譯時間長，檔案肥大
- 目前編譯出的 windows 版本，資料夾大小為 360 MB

## 環境建置
```cmd
# 安裝 ElectronNET.CLI
dotnet tool install ElectronNET.CLI -g
```

## 專案建置
```cmd
# 安裝 ElectronNET.API Nuget 套件
dotnet add package ElectronNET.API -v 9.31.2

# 僅需執行一次
electronize init

# Build 專案 會使用
electronize start

# 建置 windows 版本
electronize build /target win
```

# JuJuBotV2
.Net Framework 4.7.2 WPF 專案 測試 Three.js

透過 Owin self host 建立 http://localhost:8085 (bot)

WPF 則以 webView2 載入 bot



