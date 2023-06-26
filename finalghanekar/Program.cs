using Finalghanekar;

Console.WriteLine("Enter N value : ");
float N= Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Enter M value : ");
float M = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Enter C value : ");
float c= Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Enter h value : ");
float h= Convert.ToSingle(Console.ReadLine());
int fc = 30,fy=500;
double Ac = 3.14 * Math.Pow(h,2) / 4;
double a = (M * Math.Pow(10,6)) / (Ac * fc * h);
double b = (N * Math.Pow(10,3)) / (Ac * fc);
//Console.WriteLine(a);
//Console.WriteLine(b);
float ch;
ch = (c)/(h);
//Console.WriteLine(ch);
//Load sample data

if (ch == 0.05F)
{
    
    var sampleData = new G0_05.ModelInput()
    {
        Col0 = Convert.ToSingle(a),
        Col1 = Convert.ToSingle(b),
    };

    //Load model and predict output
    var result = G0_05.Predict(sampleData);

    Console.WriteLine(result.Score);
}

else if (ch == 0.1F)
{
    //Load sample data
   
    var sampleData = new G0_1.ModelInput()
    {
        X = Convert.ToSingle(a),
        Y = Convert.ToSingle(b),
    };

    //Load model and predict output
    var result = G0_1.Predict(sampleData);
    Console.WriteLine(result.Score);
}
else if (ch == 0.15F)
{
    //Load sample data
   
    var sampleData = new G0_15.ModelInput()
    {
        X = Convert.ToSingle(a),
        Y = Convert.ToSingle(b),
    };

    //Load model and predict output
    var result = G0_15.Predict(sampleData);
    Console.WriteLine(result.Score);
}
else if (ch == 0.20F)
{
    //Load sample data
    var sampleData = new G0_2.ModelInput()
    {
        X = Convert.ToSingle(a),
        Y = Convert.ToSingle(b),
    };

    //Load model and predict output
    var result = G0_2.Predict(sampleData);
    Console.WriteLine(result.Score);
}
else if (ch > 0.05F && ch < 0.1F)
{
    var sampleData = new G0_05.ModelInput()
    {
        Col0 = Convert.ToSingle(a),
        Col1 = Convert.ToSingle(b),
    };

    //Load model and predict output
    var result = G0_05.Predict(sampleData);


    //Load sample data
    var sampleData1 = new G0_1.ModelInput()
    {
        X = Convert.ToSingle(a),
        Y = Convert.ToSingle(b),
    };

    //Load model and predict output
    var result1 = G0_1.Predict(sampleData1);

    var omega = (((ch - 0.10F) * (result.Score - result1.Score)) / (0.05F - 0.10F)) + result1.Score;


//Load sample data
    var sampleData2 = new G0_0501.ModelInput()
    {
        Col0 = Convert.ToSingle(a),
        Col1 = Convert.ToSingle(b),
    };

    //Load model and predict output
    var result2 = G0_0501.Predict(sampleData2);
    var omega1 = result2.Score;
    if (omega > omega1)
    {
        Console.WriteLine(omega);
    }
    else
    {
        Console.WriteLine(omega1);

    }
}
else if (ch > 0.1F && ch < 0.15F)
{

    var sampleData = new G0_1.ModelInput()
    {
        X = Convert.ToSingle(a),
        Y = Convert.ToSingle(b),
    };

    //Load model and predict output
    var result = G0_1.Predict(sampleData);
    Console.WriteLine(result.Score);

    //Load sample data
    var sampleData1 = new G0_15.ModelInput()
    {
        X = Convert.ToSingle(a),
        Y = Convert.ToSingle(b),
    };

    //Load model and predict output
    var result1 = G0_15.Predict(sampleData1);
    Console.WriteLine(result1.Score);
    var omega = (((ch - 0.15F) * (result.Score - result1.Score)) / (0.1F - 0.15F)) + result1.Score;


    //Load sample data
    var sampleData2 = new G01015.ModelInput()
    {
        X = Convert.ToSingle(a),
        Y = Convert.ToSingle(b),
    };

    //Load model and predict output
    var result2 = G01015.Predict(sampleData2);
    Console.WriteLine(result2.Score);
    var omega1 = result2.Score;
    if (omega > omega1)
    {
        Console.WriteLine(omega);
    }
    else
    {
        Console.WriteLine(omega1);

    }
}
else if (ch > 0.15F && ch < 0.2F)
{
    var sampleData = new G0_15.ModelInput()
    {
        X = Convert.ToSingle(a),
        Y = Convert.ToSingle(b),
    };

    //Load model and predict output
    var result = G0_15.Predict(sampleData);


    //Load sample data
    var sampleData1 = new G0_2.ModelInput()
    {
        X = Convert.ToSingle(a),
        Y = Convert.ToSingle(b),
    };

    //Load model and predict output
    var result1 = G0_2.Predict(sampleData1);

    var omega = (((ch - 0.2F) * (result.Score - result1.Score)) / (0.15F - 0.2F)) + result1.Score;

   //Load sample data
    var sampleData2 = new G015020.ModelInput()
    {
        X = Convert.ToSingle(a),
        Y = Convert.ToSingle(b),
    };

    //Load model and predict output
    var result2 = G015020.Predict(sampleData2);
    var omega1 = result2.Score;
    if (omega > omega1)
    {
        Console.WriteLine(omega);
    }
    else
    {
        Console.WriteLine(omega1);

    }
}