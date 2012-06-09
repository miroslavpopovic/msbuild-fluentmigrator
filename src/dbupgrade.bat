call "c:\Program Files (x86)\Microsoft Visual Studio 10.0\VC\vcvarsall.bat" x86 
%FrameworkDir%\v4.0.30319\msbuild.exe /property:Configuration=Release /target:Migrate Migration.msbuild 
