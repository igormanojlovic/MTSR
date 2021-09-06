# MTSR: Multiresolution Time Series Representation
The MTSR package was used to test processing speed, RAM consumption, and cluster validity (load pattern recognition quality) for the case study performed in [Hierarchical Multiresolution Representation of Streaming Time Series](https://www.sciencedirect.com/science/article/abs/pii/S2214579621000733). The case study was performed on two datasets. One dataset was generated with this package to test the processing speed and RAM consumption. The other ([REFIT](https://pureportal.strath.ac.uk/en/datasets/refit-electrical-load-measurements-cleaned)) dataset contains real UK smart meter data, that were used to test clustering as an example of a subsequent streaming time series data mining task. Please note that this implementation is made as a proof of concept, and not as a complete production-ready package.

To fully replicate the clustering results with the REFIT dataset, run the MTSR.exe with the following list of holidays: 2013-12-25,2013-12-26,2014-01-01,2014-04-18,2014-04-21,2014-05-05,2014-05-26,2014-08-25,2014-12-25,2014-12-26,2015-01-01,2015-04-03,2015-04-06,2015-05-04,2015-05-25

Prerequisites:
1. [R 4.1.2+](https://cran.r-project.org/bin/windows/base/)
2. [RTools 4.0+](https://cran.r-project.org/bin/windows/Rtools/)
3. [Microsoft .NET 4.8+](https://dotnet.microsoft.com/en-us/download/dotnet-framework)
4. [OSIsoft PI System 2018+](https://www.osisoft.com/)
5. [Microsoft SQL Server 2017+](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
