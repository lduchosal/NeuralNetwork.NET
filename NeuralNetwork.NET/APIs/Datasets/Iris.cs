using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetworkNET.APIs.Datasets
{
    /// <summary>
    /// A class that provides quick access to the UC Irvine Machine Learning Iris Data Set
    /// https://archive.ics.uci.edu/ml/datasets/iris
    /// https://archive.ics.uci.edu/ml/machine-learning-databases/iris/
    /// 
    /// This is perhaps the best known database to be found in the pattern recognition literature.
    /// Fisher's paper is a classic in the field and is referenced frequently to this day. 
    /// (See Duda & Hart, for example.) The data set contains 3 classes of 50 instances each, 
    /// where each class refers to a type of iris plant.  One class is linearly separable from the other 2; 
    /// the latter are NOT linearly separable from each other. 
    /// </summary>
    public sealed class Iris
    {

        private string IrisUrl => "https://archive.ics.uci.edu/ml/machine-learning-databases/iris/iris.data";


        /// <summary>
        /// https://archive.ics.uci.edu/ml/machine-learning-databases/iris/iris.names
        /// Attribute Information:
        /// 1. sepal length in cm
        /// 2. sepal width in cm
        /// 3. petal length in cm
        /// 4. petal width in cm
        /// 5. class:
        /// -- Iris Setosa
        /// -- Iris Versicolour
        /// -- Iris Virginica
        /// 
        /// Sample data:
        /// 5.1,3.5,1.4,0.2,Iris-setosa
        /// 5.5,2.4,3.7,1.0,Iris-versicolor
        /// 6.3,3.3,6.0,2.5,Iris-virginica
        /// </summary>
        internal struct IrisData {
            /// <summary>
            /// sepal length in cm
            /// </summary>
            public float SepalLength;

            /// <summary>
            /// sepal width in cm
            /// </summary>
            public float SepalWidth;

            /// <summary>
            /// petal length in cm
            /// </summary>
            public float PetalLength;

            /// <summary>
            /// petal width in cm
            /// </summary>
            public float PetalWidth;

            /// <summary>
            /// class:
            /// -- Iris Setosa
            /// -- Iris Versicolour
            /// -- Iris Virginica
            /// </summary>
            public string IrisClass;
        }

    }
}
