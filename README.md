# MTSR: Multiresolution Time Series Representation

The MTSR package was used to verify the effectiveness of the solution proposed in [^1], in terms of processing speed and RAM consumption (on generated dataset), and in terms of subsequent cluster validity (on real UK smart meter data [^2]). Please note that this implementation is made as a proof of concept, and not as a complete production-ready package. However, if you are using this software, please cite reference [^1]. 

Prerequisites:
1. [R 4.1.2+](https://cran.r-project.org/bin/windows/base/)
2. [RTools 4.0+](https://cran.r-project.org/bin/windows/Rtools/)
3. [Microsoft .NET 4.8+](https://dotnet.microsoft.com/en-us/download/dotnet-framework)
4. [OSIsoft PI System 2018+](https://www.osisoft.com/)
5. [Microsoft SQL Server 2017+](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

You can also try an extended solution from the [culearn](https://github.com/igormanojlovic/culearn) package, written entirely in Python.

## References

[^1]: Igor Manojlović, Goran Švenda, Aleksandar Erdeljan, Milan Gavrić, Darko Čapko: *Hierarchical multiresolution representation of streaming time series*, Big Data Research 26: 100256 (2021), DOI: [10.1016/j.bdr.2021.100256](https://doi.org/10.1016/j.bdr.2021.100256)

[^2]: REFIT dataset, https://pureportal.strath.ac.uk/en/datasets/refit-electrical-load-measurements-cleaned