:: Restoring database backup
:: Run it with file name without extension as an argument, ie:
::    dbrestore FluentMigration-2012-06-21-21-48-43
::    dbrestore CleanBackup
:: Note that only \backup folder files are supported
call "c:\Program Files (x86)\Microsoft Visual Studio 10.0\VC\vcvarsall.bat" x86 
%FrameworkDir%\v4.0.30319\msbuild.exe /property:Configuration=Release;RestoreFileName="%~1" Migration.msbuild /target:Restore
