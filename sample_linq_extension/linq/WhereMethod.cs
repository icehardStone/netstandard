using System;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace sample_linq_extension
{
    public class WhereMethod
    {
        public readonly List<Custom> Datas = new List<Custom> {
            new Custom () {
                Name = "admas",
                Age = 20,
                Birthday = DateTime.Now,
            },
            new Custom () {
                Name = "admas",
                Age = 60,
                Birthday = DateTime.Now,
            },
            new Custom () {
                Name = "tomas",
                Age = 40,
                Birthday = DateTime.Now
            },
            new Custom () {
                Name = "tomas",
                Age = 50,
                Birthday = DateTime.Now
            }
            
        };
        public void WhereTest()
        {
            var type = typeof(Custom);
            // 构建测试方法 
            ParameterExpression parameterExpression = Expression.Parameter(type,type.Name);
            Expression names = Expression.Property(parameterExpression,typeof(Custom).GetProperty("Name"));
            Expression vals = Expression.Constant("admas");

            Expression namesExpression = Expression.Equal(names, vals);

            var  exps = Expression.Lambda<Func<Custom,bool>>(namesExpression, parameterExpression);

            var namesData = Datas.Where(exps.Compile());
            // ParameterExpression parameters1 = Expression.Parameter(type, type.Name);

            Expression age = Expression.Property(parameterExpression, type.GetProperty("Age"));
            Expression ageVals = Expression.Constant(40);

            var ageResult = Expression.GreaterThanOrEqual(age,ageVals);

            var secondExpress = Expression.And(namesExpression, ageResult);
            var  secondExps = Expression.Lambda<Func<Custom,bool>>(secondExpress, parameterExpression); 

            var secondData = Datas.Where(secondExps.Compile());


        }
    }

    public class Custom
    {
        public string Name {set;get;}
        public int Age {set;get;}
        public DateTime? Birthday {set;get;}
    }
}