public static class TestCases
{

    //-------------------------------- PASS CASES --------------------------------
    public static readonly List<List<int>> field = new List<List<int>> {
        new List<int>{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
        new List<int>{1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
        new List<int>{1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
        new List<int>{1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
        new List<int>{0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
        new List<int>{0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    };

    public static readonly List<List<int>> passFieldA = new List<List<int>> {
        new List<int>{1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{1, 0, 0, 1, 1, 1, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{1, 1, 1, 1, 0, 1, 0, 1, 1, 0},
        new List<int>{0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
        new List<int>{1, 0, 1, 1, 0, 1, 0, 0, 0, 1}
    };

    public static readonly List<List<int>> passFieldB = new List<List<int>> {
        new List<int>{0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
        new List<int>{0, 0, 0, 1, 0, 0, 0, 0, 0, 1},
        new List<int>{0, 1, 0, 0, 0, 0, 1, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 1, 0, 1, 0, 0, 0},
        new List<int>{1, 0, 0, 0, 1, 0, 1, 0, 1, 0},
        new List<int>{1, 0, 0, 0, 1, 0, 1, 0, 1, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
        new List<int>{0, 1, 0, 0, 0, 0, 0, 0, 0, 1}
    };

    //-------------------------------- FAIL CASES --------------------------------

    //out of limit
    public static readonly List<List<int>> failFieldA = new List<List<int>> {
        new List<int>{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
        new List<int>{1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
        new List<int>{1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
        new List<int>{1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
        new List<int>{0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
        new List<int>{0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
        new List<int>{0, 1, 1, 0, 0, 0, 0, 0, 0, 0}
    };

    // clean field
    public static readonly List<List<int>> failFieldB = new List<List<int>> {
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    };

    // full field
    public static readonly List<List<int>> failFieldC = new List<List<int>> {
        new List<int>{1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        new List<int>{1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        new List<int>{1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        new List<int>{1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        new List<int>{1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        new List<int>{1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        new List<int>{1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        new List<int>{1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        new List<int>{1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        new List<int>{1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
    };

    public static readonly List<List<int>> failFieldD = new List<List<int>> {
        new List<int>{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
        new List<int>{1, 0, 0, 0, 0, 0, 0, 0, 1, 0},
        new List<int>{1, 0, 0, 0, 1, 1, 1, 0, 1, 0},
        new List<int>{1, 1, 1, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
        new List<int>{0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
        new List<int>{0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    };

    public static readonly List<List<int>> failFieldE = new List<List<int>> {
        new List<int>{0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
        new List<int>{0, 1, 1, 1, 1, 0, 1, 0, 0, 0},
        new List<int>{1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{1, 0, 0, 0, 0, 0, 1, 0, 0, 0},
        new List<int>{1, 0, 1, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 1, 0, 0, 1, 0, 0, 0, 1},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
        new List<int>{0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
        new List<int>{0, 1, 0, 1, 0, 0, 0, 1, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    };

    public static readonly List<List<int>> failFieldF = new List<List<int>> {
        new List<int>{0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
        new List<int>{1, 1, 1, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 1, 1, 1, 0, 1, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 1, 1, 0, 0, 0, 1, 0, 0},
        new List<int>{0, 0, 0, 1, 1, 0, 0, 1, 0, 0},
        new List<int>{0, 1, 0, 0, 0, 0, 0, 1, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 1, 0, 1},
        new List<int>{0, 0, 0, 1, 0, 0, 0, 0, 0, 1},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    };

    public static readonly List<List<int>> failFieldG = new List<List<int>> {
        new List<int>{1, 1, 1, 1, 1, 0, 0, 0, 0, 0},
        new List<int>{1, 1, 1, 1, 1, 0, 0, 0, 0, 0},
        new List<int>{1, 1, 1, 1, 1, 0, 0, 0, 0, 0},
        new List<int>{1, 1, 1, 1, 1, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    };

    // wrong ship number
    public static readonly List<List<int>> failFieldH = new List<List<int>> {
        new List<int>{0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
        new List<int>{0, 0, 0, 1, 0, 0, 0, 0, 0, 1},
        new List<int>{0, 1, 0, 0, 0, 0, 1, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 1, 0, 1, 0, 0, 0},
        new List<int>{1, 0, 0, 0, 1, 0, 1, 0, 1, 0},
        new List<int>{1, 0, 0, 0, 1, 0, 1, 0, 1, 0},
        new List<int>{1, 0, 0, 0, 0, 0, 0, 0, 1, 0},
        new List<int>{1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 1}
    };

    public static readonly List<List<int>> failFieldI = new List<List<int>> {
        new List<int>{0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
        new List<int>{0, 0, 0, 0, 1, 1, 0, 0, 0, 0},
        new List<int>{0, 1, 1, 1, 0, 0, 0, 0, 1, 0},
        new List<int>{0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
        new List<int>{1, 0, 0, 1, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 1, 0, 1, 1, 1, 1, 0, 0, 0},
        new List<int>{0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
        new List<int>{0, 0, 0, 1, 0, 0, 1, 1, 0, 0},
        new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    };
}
