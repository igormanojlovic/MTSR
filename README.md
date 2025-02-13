# MTSR: Multiresolution Time Series Representation

This code was used to perform the case studies presented in [^1] and [^2]. If you are using this software for writing your own paper, please cite at least one of those references, whichever is more appropriate. Please note that this implementation is not production-ready but merely a proof of concept that requires many manual steps for preparing the input datasets to complete the case studies as described in [^1] and [^2]. However, I have also developed an extended solution within the [culearn](https://github.com/igormanojlovic/culearn) package, where all the manual steps are automated, so I encourage you to use that package instead.

## Prerequisites

1. [R 4.1.2+](https://cran.r-project.org/bin/windows/base/)
2. [RTools 4.0+](https://cran.r-project.org/bin/windows/Rtools/)
3. [Microsoft .NET 4.8+](https://dotnet.microsoft.com/en-us/download/dotnet-framework)
4. [OSIsoft PI System 2018+](https://www.osisoft.com/)
5. [Microsoft SQL Server 2017+](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

## References

[^1]: Igor Manojlović, Goran Švenda, Aleksandar Erdeljan, Milan Gavrić, Darko Čapko: *Hierarchical multiresolution representation of streaming time series*, Big Data Research 26: 100256 (2021), DOI: [10.1016/j.bdr.2021.100256](https://doi.org/10.1016/j.bdr.2021.100256)

[^2]: Igor Manojlović, *Kratkoročna probabilistička prognoza opterećenja na niskom naponu u elektrodistributivnim mrežama* | *Probabilistic short-term load forecasting at low voltage in distribution networks*, PhD Thesis, Faculty of Technical Sciences, University of Novi Sad, 2023, [link](https://nardus.mpn.gov.rs/handle/123456789/21279)
