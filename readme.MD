# JuJuBot

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