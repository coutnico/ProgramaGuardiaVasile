echo off
cls
md c:\auxi
md c:\auxi\CapturarIngresosVMate
md c:\auxi\CapturarIngresosVMate\bin
md c:\auxi\CapturarIngresosVMate\bin\Debug
md c:\auxi\CapturarIngresosVMate\bin\Release
copy ..\Debug\*.*   c:\auxi\CapturarIngresosVMate\bin\Debug 
copy ..\Release\*.* c:\auxi\CapturarIngresosVMate\bin\Release
c:\auxi\CapturarIngresosVMate\bin\debug\capturaringresos