# AlgorithmVisualizer

A repository containing projects used for visualizing various algorithms.

## AlgorithmVisualizerLibrary

A C# library containing most popular sort algorithms.
Each implementation of `ISortAlgorithmVisualizer` has an optional `SortProgress` callback that can be used to track state of the sorting progress.

## WebSortAlgorithmVisualizer

A Blazor WebAssembly (WASM) project.
Demonstrates interop between C# and JavaScript by using sorting algorithms from `AlgorithmVisualizerLibrary` and charts from [ApexCharts](https://apexcharts.com/).

![Sample Page](./images/sample-page.jpg)

The sample page is hosted @ [GitHubPages](https://ralphfe.github.io/AlgorithmVisualizer/)
