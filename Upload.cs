﻿<?xml version="1.0" encoding="utf-8" standalone="no"?>
<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">
    <RestoreSuccess Condition=" '$(RestoreSuccess)' == '' ">True</RestoreSuccess>
    <RestoreTool Condition=" '$(RestoreTool)' == '' ">NuGet</RestoreTool>
    <ProjectAssetsFile Condition=" '$(ProjectAssetsFile)' == '' ">$(MSBuildThisFileDirectory)project.assets.json</ProjectAssetsFile>
    <NuGetPackageRoot Condition=" '$(NuGetPackageRoot)' == '' ">$(UserProfile)\.nuget\packages\</NuGetPackageRoot>
    <NuGetPackageFolders Condition=" '$(NuGetPackageFolders)' == '' ">C:\Users\user01\.nuget\packages\;C:\Program Files\dotnet\sdk\NuGetFallbackFolder</NuGetPackageFolders>
    <NuGetProjectStyle Condition=" '$(NuGetProjectStyle)' == '' ">PackageReference</NuGetProjectStyle>
    <NuGetToolVersion Condition=" '$(NuGetToolVersion)' == '' ">5.1.0</NuGetToolVersion>
  </PropertyGroup>
  <PropertyGroup>
    <MSBuildAllProjects>$(MSBuildAllProjects);$(MSBuildThisFileFullPath)</MSBuildAllProjects>
  </PropertyGroup>
  <ImportGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">
    <Import Project="$(NuGetPackageRoot)mstest.testadapter\1.4.0\build\netcoreapp1.0\MSTest.TestAdapter.props" Condition="Exists('$(NuGetPackageRoot)mstest.testadapter\1.4.0\build\netcoreapp1.0\MSTest.TestAdapter.props')" />
    <Import Project="$(NuGetPackageRoot)microsoft.netcore.app\2.2.0\build\netcoreapp2.2\Microsoft.NETCore.App.props" Condition="Exists('$(NuGetPackageRoot)microsoft.netcore.app\2.2.0\build\netcoreapp2.2\Microsoft.NETCore.App.props')" />
    <Import Project="$(NuGetPackageRoot)microsoft.codecoverage\16.0.1\build\netstandard1.0\Microsoft.CodeCoverage.props" Condition="Exists('$(NuGetPackageRoot)microsoft.codecoverage\16.0.1\build\netstandard1.0\Microsoft.CodeCoverage.props')" />
    <Import Project="$(NuGetPackageRoot)microsoft.net.test.sdk\16.0.1\build\netcoreapp1.0\Microsoft.NET.Test.Sdk.props" Condition="Exists('$(NuGetPackageRoot)microsoft.net.test.sdk\16.0.1\build\netcoreapp1.0\Microsoft.NET.Test.Sdk.props')" />
  </ImportGroup>
  <PropertyGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">
    <PkgMicrosoft_EntityFrameworkCore_Tools Condition=" '$(PkgMicrosoft_EntityFrameworkCore_Tools)' == '' ">C:\Users\user01\.nuget\packages\microsoft.entityframeworkcore.tools\2.2.0</PkgMicrosoft_EntityFrameworkCore_Tools>
    <PkgMicrosoft_CodeAnalysis_Analyzers Condition=" '$(PkgMicrosoft_CodeAnalysis_Analyzers)' == '' ">C:\Users\user01\.nuget\packages\microsoft.codeanalysis.analyzers\1.1.0</PkgMicrosoft_CodeAnalysis_Analyzers>
    <PkgMicrosoft_AspNetCore_Razor_Design Condition=" '$(PkgMicrosoft_AspNetCore_Razor_Design)' == '' ">C:\Users\user01\.nuget\packages\microsoft.aspnetcore.razor.design\2.2.0</PkgMicrosoft_AspNetCore_Razor_Design>
  </PropertyGroup>
</Project>