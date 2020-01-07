# System.Collections.Generic

类似的数据在作为集合而存储和操作时通常得到更高效的处理。可以使用**System.Array** 类 

## 集合的类型

**泛型集合** 和 **非泛型集合**，泛型集合通常能够提供更好的性能

所有直接或者间接实现ICollection 接口或者 ICollection<T>**接口的集合均具有在集合中**添加**， **删除**， **查找** 的方法

## 集合的功能

* 计数和容量功能
集合的容量是它可包含的元素数量，计数是它实际包含元素数量。
达到当前容量时，大多数结合会自动扩展容量，重新分配内存，并将元素从旧的集合复制到新的集合。
例如：

> 对于**List&lt;T&gt;**来说,如果**Count**比**Capicity**小，那么添加项就是一个**O(1)**操作，如需增加容量以容纳新的元素，则添加项目成为**O(n)**操作，其中n是**Count**。即为集合开始扩容，容量变为原来的两倍。所以，避免因为多次分配而导致的性能较差的最佳方式：将初始容量设置为估计值的大小。

| 泛型集合选项 | 非泛型集合选项 | 线程安全或者不可变集合选项 |
| :---------- | :------------ | :-----------------------|
| Dictionart&lt;TKey,TValue&gt; | Hashtable | ConcurrentDictionary&lt;TKey,TValue&gt;<br/>ReadOnlyDictionary&lt;TKey,TValue&gt;<br/>ImmutableDictionary&lt;TKey,TValue&gt;<br/> |
| List&lt;T&gt; | Array <br/> ArrayList | ImmutableList&lt;T&gt;<br/> ImmutableArrat |
| Queue&lt;T&gt; | Queue | ConcurrentQueue&lt;T&gt; ImmutableQueue&lt;T&gt; |
| Stack&lt;T&gt; | Stack | ConcurrentStack&lt;T&gt; |
|  LinkedList&lt;T&gt; | |
| ObservableCollection&lt;T&gt; | |
|  SortedList&lt;TKey,TValue&gt; | SortedList | ImmutableSortedDictionary&lt;TKey,TValue&gt;<br/> ImmutableSortedSet&lt;T&gt; |
| HashSet&lt;T&gt; |  | ImmutableHashSet&lt;T&gt; <br/> ImmutableSorted&lt;T&gt; |

# System.Collection.Concurrent

该命名空间存放一些并发集合类

## BlockingCollection&lt;T&gt;s

* 该类是一个线程安全集合类。提供了IProducerConsumerCollection&lt;T&gt;接口的实现。
* 通过**Add,Take**
* 一个绑定结合，用于在集合已经满或者集合为空时候堵塞
* 使用tryAdd或者TryTake方法中的CancellationToken对象取消Add或者Take操作
