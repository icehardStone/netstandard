# IO 操作

## Stream

&nbsp;&nbsp;抽象基类Stream 支持读取和写入字节。所有的类都继承自 [Stream]('') 类，Stream类及其派生类提供数据源和存储库的常见视图，使得程序员不必了解操作系统和基础设备的具体细节。

### 流涉及的三个基本操作

* [读取]('') - 将数据从流传输到数据结构(如字节数组)中。
* [写入]('') - 将数据从数据源传输到流
* [查找]('') - 对流中的当前位置进行查询和修改

| 常用流 | 作用 |
| :------ | :------|
| [FileStream]('') | 用于对文件进行读取和写入操作 |
| [IsolatedStorageFileStream]('') | 用于对独立存储的文件进行读取或者写入操作 |
| [MemoryStream]('') | 用于作为后备存储对内存进行读取和写入操作 |
| [BufferedStream]('') | 用于改进读取和写入操作的性能 |
| [NetworkStream]('') | 用于通过网络套接字进行读取和写入 |
| [PipeStream]('') | 用于通过匿名和命名管道进行读取和写入 |
| [CryptoStream]('') | 用于将数据流链接到加密转换 |

### 本文演示内存流的使用

使用内存来作为后备储存来对数据进行读取和写入

#### 注解

* 流的当前位置指的是下一次读取或者写入可能发生的位置。可以通过[Seek]('') 方法检索或者设置当前位置，创建MemoryStream新实例时，默认当前位置为零。
