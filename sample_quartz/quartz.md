# quartz 定时器框架

## Trigger 是用于定义调度时间和触发规则的元素，在Quartz 框架中，Trigger分为四种类型：SimpleTrigger,CronTirgger,DateIntervalTrigger,和NthIncludedDayTrigger。

* SimpleTrigger 简单触发器
* CronTriggerWW
* DateIntervalTrigger
* NthIncludedDayTrigger

## ScheduleFactory 调度器工厂类型

调度器负责所有任务的实际调度，并且Quatz的运行的环境也由他管理。调度器由调度器工厂创建，调度器工厂分为两种类型：DirectSchedulerFactory 和StdSchedulerFactory其中，第二种工厂被使用的频率较高，因为第一种工厂DirectSchedulerFactory 使用起来比较麻烦，需要开发人员设置许多详细的配置。

## Quartz 集群

Quartz集群中，独立的Quartz节点并不与其他节点直接通信，而是通过相同的数据库表scheduler_locks来感知到另一个Quartz节点。通过该表对触发器进行数据库加锁，Quartz集群可以保证同一个任务只能在一个Quartz服务器节点上执行，确保任务同步的正确性。

简而言之，Quartz的集群解决方案就是基于数据库的一种调度异步策略。每个Quartz节点都服从一个基于数据库锁的规范，这样确保任务执行的唯一性。

### MySQL 数据库的锁机制

* 按照操作划分：DML锁，DDL锁，
* 按照锁的粒度划分，表级锁，行级锁，页级锁，
* 按照锁级别划分：共享锁，排他锁，
* 按照使用方式划分:乐观锁，悲观锁，