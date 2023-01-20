class Program6
    {
    var sources = new Dictionary<string, object>()
            {
                {"source1",  "kozhikode"  },
                {"source2",  "kochi"  },
                { "source3", "trivandrum"  },
                { "source4", "chennai"  },
                { "source5", "mumbai"  }
            };
    var destinations = new Dictionary<string, object>()
            {
                {"dest1", "kozhikode"  },
                {"dest2", "kochi"  },
                { "dest3", "trivandrum"  },
                { "dest4", "chennai"  },
                { "dest5", "mumbai"  }
            };

    string[] destination =  new string[5];
        Double distance = new Double();
        float fare = new float();

    public object Sources { get => sources; set => sources = value; }
}

