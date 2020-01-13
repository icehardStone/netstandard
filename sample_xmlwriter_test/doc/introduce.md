# XmlWriterSetting

提供数据一致性和输出格式的属性

| Property | 作用 |
| :-------- | :---- |
|CheckCharacters | 检查是否字符符合W3C定义的合法XML字符集 |
|COnformanceLevel| 是否检查输出是否为格式正确的XML1.0文档或者片段|
|WriteEndDocumentOnClose | 调用Close方法时是否向所有未关闭的元素添加结束标记 |

## 输出格式属性

| Property            | 作用              |
| :--------           | :-----            |
| Encoding            | 文本编码          |
| Indent              | 是否缩进          |
| IndexChars          | 缩进时使用的字符串 |
| NewLineChars        | 用于分行符的字符串 |
| NewLineHanding      | 如何处理换行符     |
| NewLineOnAttributes | 是否在单个行商写入属性|
| OmitXmlDeclaration  | 是否写入XML声明 |
