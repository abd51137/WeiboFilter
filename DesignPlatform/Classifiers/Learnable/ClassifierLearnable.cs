﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPlatform.Classifiers
{
    abstract class ClassifierLearnable : Classifier
    {
        public Detector _detector { get; set; }

        public abstract void train(string comment, string category);

        public abstract void untrain(string comment, string category);

        public abstract void showModelInfo();
    }
}
