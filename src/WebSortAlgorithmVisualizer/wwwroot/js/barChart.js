var chart;
var barDefaultColor = "#008ffb";

function generateBarChart(values) {
    var options = {
        series: [{
            data: values
        }],
        chart: {
            type: 'bar',
            height: 350,
            selection: {
                enabled: false,
            },
            zoom: {
                enabled: false,
            },
            animations: {
                enabled: false,
            },
            toolbar: {
                show: false
            },
        },
        legend: {
            show: false,
        },
        markers: {
            size: 0
        },
        plotOptions: {
            bar: {
                horizontal: false,
                distributed: true,
            },
        },
        fill: {
            colors: [barDefaultColor],
        },
        dataLabels: {
            enabled: false
        },
        tooltip: {
            enabled: false,
        },
        states: {
            normal: {
                filter: {
                    type: 'none',
                }
            },
            hover: {
                filter: {
                    type: 'none',
                }
            },
            active: {
                allowMultipleDataPointsSelection: false,
                filter: {
                    type: 'none',
                }
            },
        },
        grid: {
            show: false,
        },
        xaxis: {
            labels: {
                show: false,
            },
            axisBorder: {
                show: false,
            },
            axisTicks: {
                show: false,
            },
            tooltip: {
                enabled: false,
            },
            crosshairs: {
                show: false,
            },
        },
        yaxis: {
            labels: {
                show: false,
            },
            axisBorder: {
                show: false,
            },
            axisTicks: {
                show: false,
            },
            tooltip: {
                enabled: false,
            },
            crosshairs: {
                show: false,
            },
        },
    };

    chart = new ApexCharts(document.querySelector("#chart"), options);
    chart.render();
}

function updateBarChartSeries(values) {
    chart.updateSeries([{
        data: values
    }]);
}

function updateBarChart(values, index) {
    chart.updateOptions({
        series: [{
            data: values
        }],
        fill: {
            colors: [function ({ value, seriesIndex, w }) {
                if (seriesIndex === index) {
                    return '#eb3434';
                } else {
                    return '#164666';
                }
            }]
        }
    });
}

function resetBarChartColors() {
    chart.updateOptions({
        fill: {
            colors: [barDefaultColor],
        }
    });
}

function destroyBarChart() {
    if (chart == "undefined") {
        chart.destroy();
        chart = "undefined";
    }
}