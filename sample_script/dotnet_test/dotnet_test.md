# dotnet test

## dotnet test --help

``` shell

用法: dotnet test [选项] <项目 | 解决方案> [[--] <RunSettings arguments>...]]

参数:
  <项目 | 解决方案>   要操作的项目或解决方案文件。如果没有指定文件，则命令将在当前目录里搜索一个文件。

选项:
  -h, --help                               显示命令行帮助。
  -s, --settings <SETTINGS_FILE>           运行测试时要使用的设置文件。
  -t, --list-tests                         列出已发现的测试，而不是运行测试。
  --filter <EXPRESSION>                    运行与给定表达式匹配的测试。
                                           示例:
                                           运行优先级设置为 1 的测试: --filter "Priority = 1"
                                           运行指定全名的测试:  --filter "FullyQualifiedName=Namespace.ClassName.MethodName"
                                           运行包含指定名称的测试: --filter "FullyQualifiedName~Namespace.Class"
                                           有关筛选支持的详细信息，请参阅 https://aka.ms/vstest-filtering。

  -a, --test-adapter-path <ADAPTER_PATH>   自定义适配器用于测试运行的路径。
  -l, --logger <LOGGER>                    要用于测试结果的记录器。
                                           示例:
                                           使用唯一的文件名登录 trx 格式: --记录器 trx
                                           使用指定的文件名登录 trx 格式: --记录器 "trx;LogFileName=<TestResults.trx>"
                                           有关记录器参数的详细信息，请参阅 https://aka.ms/vstest-report。
  -c, --configuration <CONFIGURATION>      用于运行测试的配置。大多数项目的默认值是 "Debug"。
  -f, --framework <FRAMEWORK>              运行测试的目标框架。必须在项目文件中指定目标框架。
  --runtime <RUNTIME_IDENTIFIER>           要为其测试的目标运行时。
  -o, --output <OUTPUT_DIR>                要放置生成项目的输出目录。
  -d, --diag <LOG_FILE>                    启用对指定文件的详细记录。
  --no-build                               测试之前不要生成项目。Implies --no-restore.
  -r, --results-directory <RESULTS_DIR>    要放置测试结果的目录。
                                           若不存在，将创建指定目录。
  --collect <DATA_COLLECTOR_NAME>          用于测试运行的数据收集器的友好名称。
                                           有关详细信息，请访问: https://aka.ms/vstest-collect
  --blame                                  在追责模式下运行测试。此选项有助于隔离有问题的测试，以免导致测试主机崩溃。
                                           在当前目录中输出一个 "Sequence.xml" 文件，该文件在崩溃之前捕获测试的执行顺序。
  /nologo, --nologo                        运行测试，而不显示 Microsoft Testplatform 版权标志
  --no-restore                             生成前请勿还原项目。
  --interactive                            允许命令停止和等待用户输入或操作(例如，用以完成身份验证)。
  -v, --verbosity <LEVEL>                  设置 MSBuild 详细程度。允许值为 q[uiet]、m[inimal]、n[ormal]、d[etailed] 和 diag[nostic]。


RunSettings 参数:
  作为 RunSettings 配置传递的参数。参数在 "-- " 之后被指定为“[名称]=[值]”对(注意 -- 之后的空格)。
  使用空格分隔多个“[名称]=[值]”对。
  有关 RunSettings 参数的详细信息，请参阅 https://aka.ms/vstest-runsettings-arguments。
  示例: dotnet test -- MSTest.DeploymentEnabled=false MSTest.MapInconclusiveToFailed=True
```