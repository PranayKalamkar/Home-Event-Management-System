(function ($) {
    'use strict';
    $(function () {
        if ($("#order-chart").length) {
            var areaData = {
                labels: ["10", "", "", "20", "", "", "30", "", "", "40", "", "", "50", "", "", "60", "", "", "70"],
                datasets: [
                    {
                        data: [200, 480, 700, 600, 620, 350, 380, 350, 850, "600", "650", "350", "590", "350", "620", "500", "990", "780", "650"],
                        borderColor: [
                            '#4747A1'
                        ],
                        borderWidth: 2,
                        fill: false,
                        label: "Orders"
                    },
                    {
                        data: [400, 450, 410, 500, 480, 600, 450, 550, 460, "560", "450", "700", "450", "640", "550", "650", "400", "850", "800"],
                        borderColor: [
                            '#F09397'
                        ],
                        borderWidth: 2,
                        fill: false,
                        label: "Downloads"
                    }
                ]
            };
            var areaOptions = {
                responsive: true,
                maintainAspectRatio: true,
                plugins: {
                    filler: {
                        propagate: false
                    }
                },
                scales: {
                    xAxes: [{
                        display: true,
                        ticks: {
                            display: true,
                            padding: 10,
                            fontColor: "#6C7383"
                        },
                        gridLines: {
                            display: false,
                            drawBorder: false,
                            color: 'transparent',
                            zeroLineColor: '#eeeeee'
                        }
                    }],
                    yAxes: [{
                        display: true,
                        ticks: {
                            display: true,
                            autoSkip: false,
                            maxRotation: 0,
                            stepSize: 200,
                            min: 200,
                            max: 1200,
                            padding: 18,
                            fontColor: "#6C7383"
                        },
                        gridLines: {
                            display: true,
                            color: "#f2f2f2",
                            drawBorder: false
                        }
                    }]
                },
                legend: {
                    display: false
                },
                tooltips: {
                    enabled: true
                },
                elements: {
                    line: {
                        tension: .35
                    },
                    point: {
                        radius: 0
                    }
                }
            }
            var revenueChartCanvas = $("#order-chart").get(0).getContext("2d");
            var revenueChart = new Chart(revenueChartCanvas, {
                type: 'line',
                data: areaData,
                options: areaOptions
            });
        }
        if ($("#order-chart-dark").length) {
            var areaData = {
                labels: ["10", "", "", "20", "", "", "30", "", "", "40", "", "", "50", "", "", "60", "", "", "70"],
                datasets: [
                    {
                        data: [200, 480, 700, 600, 620, 350, 380, 350, 850, "600", "650", "350", "590", "350", "620", "500", "990", "780", "650"],
                        borderColor: [
                            '#4747A1'
                        ],
                        borderWidth: 2,
                        fill: false,
                        label: "Orders"
                    },
                    {
                        data: [400, 450, 410, 500, 480, 600, 450, 550, 460, "560", "450", "700", "450", "640", "550", "650", "400", "850", "800"],
                        borderColor: [
                            '#F09397'
                        ],
                        borderWidth: 2,
                        fill: false,
                        label: "Downloads"
                    }
                ]
            };
            var areaOptions = {
                responsive: true,
                maintainAspectRatio: true,
                plugins: {
                    filler: {
                        propagate: false
                    }
                },
                scales: {
                    xAxes: [{
                        display: true,
                        ticks: {
                            display: true,
                            padding: 10,
                            fontColor: "#fff"
                        },
                        gridLines: {
                            display: false,
                            drawBorder: false,
                            color: 'transparent',
                            zeroLineColor: '#575757'
                        }
                    }],
                    yAxes: [{
                        display: true,
                        ticks: {
                            display: true,
                            autoSkip: false,
                            maxRotation: 0,
                            stepSize: 200,
                            min: 200,
                            max: 1200,
                            padding: 18,
                            fontColor: "#fff"
                        },
                        gridLines: {
                            display: true,
                            color: "#575757",
                            drawBorder: false
                        }
                    }]
                },
                legend: {
                    display: false
                },
                tooltips: {
                    enabled: true
                },
                elements: {
                    line: {
                        tension: .35
                    },
                    point: {
                        radius: 0
                    }
                }
            }
            var revenueChartCanvas = $("#order-chart-dark").get(0).getContext("2d");
            var revenueChart = new Chart(revenueChartCanvas, {
                type: 'line',
                data: areaData,
                options: areaOptions
            });
        }
        if ($("#sales-chart").length) {
            var SalesChartCanvas = $("#sales-chart").get(0).getContext("2d");
            var SalesChart = new Chart(SalesChartCanvas, {
                type: 'bar',
                data: {
                    labels: ["Jan", "Feb", "Mar", "Apr", "May"],
                    datasets: [{
                        label: 'Offline Sales',
                        data: [480, 230, 470, 210, 330],
                        backgroundColor: '#98BDFF'
                    },
                    {
                        label: 'Online Sales',
                        data: [400, 340, 550, 480, 170],
                        backgroundColor: '#4B49AC'
                    }
                    ]
                },
                options: {
                    cornerRadius: 5,
                    responsive: true,
                    maintainAspectRatio: true,
                    layout: {
                        padding: {
                            left: 0,
                            right: 0,
                            top: 20,
                            bottom: 0
                        }
                    },
                    scales: {
                        yAxes: [{
                            display: true,
                            gridLines: {
                                display: true,
                                drawBorder: false,
                                color: "#F2F2F2"
                            },
                            ticks: {
                                display: true,
                                min: 0,
                                max: 560,
                                callback: function (value, index, values) {
                                    return value + '$';
                                },
                                autoSkip: true,
                                maxTicksLimit: 10,
                                fontColor: "#6C7383"
                            }
                        }],
                        xAxes: [{
                            stacked: false,
                            ticks: {
                                beginAtZero: true,
                                fontColor: "#6C7383"
                            },
                            gridLines: {
                                color: "rgba(0, 0, 0, 0)",
                                display: false
                            },
                            barPercentage: 1
                        }]
                    },
                    legend: {
                        display: false
                    },
                    elements: {
                        point: {
                            radius: 0
                        }
                    }
                },
            });
            document.getElementById('sales-legend').innerHTML = SalesChart.generateLegend();
        }
        if ($("#sales-chart-dark").length) {
            var SalesChartCanvas = $("#sales-chart-dark").get(0).getContext("2d");
            var SalesChart = new Chart(SalesChartCanvas, {
                type: 'bar',
                data: {
                    labels: ["Jan", "Feb", "Mar", "Apr", "May"],
                    datasets: [{
                        label: 'Offline Sales',
                        data: [480, 230, 470, 210, 330],
                        backgroundColor: '#98BDFF'
                    },
                    {
                        label: 'Online Sales',
                        data: [400, 340, 550, 480, 170],
                        backgroundColor: '#4B49AC'
                    }
                    ]
                },
                options: {
                    cornerRadius: 5,
                    responsive: true,
                    maintainAspectRatio: true,
                    layout: {
                        padding: {
                            left: 0,
                            right: 0,
                            top: 20,
                            bottom: 0
                        }
                    },
                    scales: {
                        yAxes: [{
                            display: true,
                            gridLines: {
                                display: true,
                                drawBorder: false,
                                color: "#575757"
                            },
                            ticks: {
                                display: true,
                                min: 0,
                                max: 500,
                                callback: function (value, index, values) {
                                    return value + '$';
                                },
                                autoSkip: true,
                                maxTicksLimit: 10,
                                fontColor: "#F0F0F0"
                            }
                        }],
                        xAxes: [{
                            stacked: false,
                            ticks: {
                                beginAtZero: true,
                                fontColor: "#F0F0F0"
                            },
                            gridLines: {
                                color: "#575757",
                                display: false
                            },
                            barPercentage: 1
                        }]
                    },
                    legend: {
                        display: false
                    },
                    elements: {
                        point: {
                            radius: 0
                        }
                    }
                },
            });
            document.getElementById('sales-legend').innerHTML = SalesChart.generateLegend();
        }
        if ($("#north-america-chart").length) {
            var areaData = {
                labels: ["Jan", "Feb", "Mar"],
                datasets: [{
                    data: [100, 50, 50],
                    backgroundColor: [
                        "#4B49AC", "#FFC100", "#248AFD",
                    ],
                    borderColor: "rgba(0,0,0,0)"
                }
                ]
            };
            var areaOptions = {
                responsive: true,
                maintainAspectRatio: true,
                segmentShowStroke: false,
                cutoutPercentage: 78,
                elements: {
                    arc: {
                        borderWidth: 4
                    }
                },
                legend: {
                    display: false
                },
                tooltips: {
                    enabled: true
                },
                legendCallback: function (chart) {
                    var text = [];
                    text.push('<div class="report-chart">');
                    text.push('<div class="d-flex justify-content-between mx-4 mx-xl-5 mt-3"><div class="d-flex align-items-center"><div class="mr-3" style="width:20px; height:20px; border-radius: 50%; background-color: ' + chart.data.datasets[0].backgroundColor[0] + '"></div><p class="mb-0">Offline sales</p></div>');
                    text.push('<p class="mb-0">88333</p>');
                    text.push('</div>');
                    text.push('<div class="d-flex justify-content-between mx-4 mx-xl-5 mt-3"><div class="d-flex align-items-center"><div class="mr-3" style="width:20px; height:20px; border-radius: 50%; background-color: ' + chart.data.datasets[0].backgroundColor[1] + '"></div><p class="mb-0">Online sales</p></div>');
                    text.push('<p class="mb-0">66093</p>');
                    text.push('</div>');
                    text.push('<div class="d-flex justify-content-between mx-4 mx-xl-5 mt-3"><div class="d-flex align-items-center"><div class="mr-3" style="width:20px; height:20px; border-radius: 50%; background-color: ' + chart.data.datasets[0].backgroundColor[2] + '"></div><p class="mb-0">Returns</p></div>');
                    text.push('<p class="mb-0">39836</p>');
                    text.push('</div>');
                    text.push('</div>');
                    return text.join("");
                },
            }
            var northAmericaChartPlugins = {
                beforeDraw: function (chart) {
                    var width = chart.chart.width,
                        height = chart.chart.height,
                        ctx = chart.chart.ctx;

                    ctx.restore();
                    var fontSize = 3.125;
                    ctx.font = "500 " + fontSize + "em sans-serif";
                    ctx.textBaseline = "middle";
                    ctx.fillStyle = "#13381B";

                    var text = "90",
                        textX = Math.round((width - ctx.measureText(text).width) / 2),
                        textY = height / 2;

                    ctx.fillText(text, textX, textY);
                    ctx.save();
                }
            }
            var northAmericaChartCanvas = $("#north-america-chart").get(0).getContext("2d");
            var northAmericaChart = new Chart(northAmericaChartCanvas, {
                type: 'doughnut',
                data: areaData,
                options: areaOptions,
                plugins: northAmericaChartPlugins
            });
            document.getElementById('north-america-legend').innerHTML = northAmericaChart.generateLegend();
        }
        if ($("#north-america-chart-dark").length) {
            var areaData = {
                labels: ["Jan", "Feb", "Mar"],
                datasets: [{
                    data: [100, 50, 50],
                    backgroundColor: [
                        "#4B49AC", "#FFC100", "#248AFD",
                    ],
                    borderColor: "rgba(0,0,0,0)"
                }
                ]
            };
            var areaOptions = {
                responsive: true,
                maintainAspectRatio: true,
                segmentShowStroke: false,
                cutoutPercentage: 78,
                elements: {
                    arc: {
                        borderWidth: 4
                    }
                },
                legend: {
                    display: false
                },
                tooltips: {
                    enabled: true
                },
                legendCallback: function (chart) {
                    var text = [];
                    text.push('<div class="report-chart">');
                    text.push('<div class="d-flex justify-content-between mx-4 mx-xl-5 mt-3"><div class="d-flex align-items-center"><div class="mr-3" style="width:20px; height:20px; border-radius: 50%; background-color: ' + chart.data.datasets[0].backgroundColor[0] + '"></div><p class="mb-0">Offline sales</p></div>');
                    text.push('<p class="mb-0">88333</p>');
                    text.push('</div>');
                    text.push('<div class="d-flex justify-content-between mx-4 mx-xl-5 mt-3"><div class="d-flex align-items-center"><div class="mr-3" style="width:20px; height:20px; border-radius: 50%; background-color: ' + chart.data.datasets[0].backgroundColor[1] + '"></div><p class="mb-0">Online sales</p></div>');
                    text.push('<p class="mb-0">66093</p>');
                    text.push('</div>');
                    text.push('<div class="d-flex justify-content-between mx-4 mx-xl-5 mt-3"><div class="d-flex align-items-center"><div class="mr-3" style="width:20px; height:20px; border-radius: 50%; background-color: ' + chart.data.datasets[0].backgroundColor[2] + '"></div><p class="mb-0">Returns</p></div>');
                    text.push('<p class="mb-0">39836</p>');
                    text.push('</div>');
                    text.push('</div>');
                    return text.join("");
                },
            }
            var northAmericaChartPlugins = {
                beforeDraw: function (chart) {
                    var width = chart.chart.width,
                        height = chart.chart.height,
                        ctx = chart.chart.ctx;

                    ctx.restore();
                    var fontSize = 3.125;
                    ctx.font = "500 " + fontSize + "em sans-serif";
                    ctx.textBaseline = "middle";
                    ctx.fillStyle = "#fff";

                    var text = "90",
                        textX = Math.round((width - ctx.measureText(text).width) / 2),
                        textY = height / 2;

                    ctx.fillText(text, textX, textY);
                    ctx.save();
                }
            }
            var northAmericaChartCanvas = $("#north-america-chart-dark").get(0).getContext("2d");
            var northAmericaChart = new Chart(northAmericaChartCanvas, {
                type: 'doughnut',
                data: areaData,
                options: areaOptions,
                plugins: northAmericaChartPlugins
            });
            document.getElementById('north-america-legend').innerHTML = northAmericaChart.generateLegend();
        }

        if ($("#south-america-chart").length) {
            var areaData = {
                labels: ["Jan", "Feb", "Mar"],
                datasets: [{
                    data: [60, 70, 70],
                    backgroundColor: [
                        "#4B49AC", "#FFC100", "#248AFD",
                    ],
                    borderColor: "rgba(0,0,0,0)"
                }
                ]
            };
            var areaOptions = {
                responsive: true,
                maintainAspectRatio: true,
                segmentShowStroke: false,
                cutoutPercentage: 78,
                elements: {
                    arc: {
                        borderWidth: 4
                    }
                },
                legend: {
                    display: false
                },
                tooltips: {
                    enabled: true
                },
                legendCallback: function (chart) {
                    var text = [];
                    text.push('<div class="report-chart">');
                    text.push('<div class="d-flex justify-content-between mx-4 mx-xl-5 mt-3"><div class="d-flex align-items-center"><div class="mr-3" style="width:20px; height:20px; border-radius: 50%; background-color: ' + chart.data.datasets[0].backgroundColor[0] + '"></div><p class="mb-0">Offline sales</p></div>');
                    text.push('<p class="mb-0">495343</p>');
                    text.push('</div>');
                    text.push('<div class="d-flex justify-content-between mx-4 mx-xl-5 mt-3"><div class="d-flex align-items-center"><div class="mr-3" style="width:20px; height:20px; border-radius: 50%; background-color: ' + chart.data.datasets[0].backgroundColor[1] + '"></div><p class="mb-0">Online sales</p></div>');
                    text.push('<p class="mb-0">630983</p>');
                    text.push('</div>');
                    text.push('<div class="d-flex justify-content-between mx-4 mx-xl-5 mt-3"><div class="d-flex align-items-center"><div class="mr-3" style="width:20px; height:20px; border-radius: 50%; background-color: ' + chart.data.datasets[0].backgroundColor[2] + '"></div><p class="mb-0">Returns</p></div>');
                    text.push('<p class="mb-0">290831</p>');
                    text.push('</div>');
                    text.push('</div>');
                    return text.join("");
                },
            }
            var southAmericaChartPlugins = {
                beforeDraw: function (chart) {
                    var width = chart.chart.width,
                        height = chart.chart.height,
                        ctx = chart.chart.ctx;

                    ctx.restore();
                    var fontSize = 3.125;
                    ctx.font = "600 " + fontSize + "em sans-serif";
                    ctx.textBaseline = "middle";
                    ctx.fillStyle = "#000";

                    var text = "76",
                        textX = Math.round((width - ctx.measureText(text).width) / 2),
                        textY = height / 2;

                    ctx.fillText(text, textX, textY);
                    ctx.save();
                }
            }
            var southAmericaChartCanvas = $("#south-america-chart").get(0).getContext("2d");
            var southAmericaChart = new Chart(southAmericaChartCanvas, {
                type: 'doughnut',
                data: areaData,
                options: areaOptions,
                plugins: southAmericaChartPlugins
            });
            document.getElementById('south-america-legend').innerHTML = southAmericaChart.generateLegend();
        }
        if ($("#south-america-chart-dark").length) {
            var areaData = {
                labels: ["Jan", "Feb", "Mar"],
                datasets: [{
                    data: [60, 70, 70],
                    backgroundColor: [
                        "#4B49AC", "#FFC100", "#248AFD",
                    ],
                    borderColor: "rgba(0,0,0,0)"
                }
                ]
            };
            var areaOptions = {
                responsive: true,
                maintainAspectRatio: true,
                segmentShowStroke: false,
                cutoutPercentage: 78,
                elements: {
                    arc: {
                        borderWidth: 4
                    }
                },
                legend: {
                    display: false
                },
                tooltips: {
                    enabled: true
                },
                legendCallback: function (chart) {
                    var text = [];
                    text.push('<div class="report-chart">');
                    text.push('<div class="d-flex justify-content-between mx-4 mx-xl-5 mt-3"><div class="d-flex align-items-center"><div class="mr-3" style="width:20px; height:20px; border-radius: 50%; background-color: ' + chart.data.datasets[0].backgroundColor[0] + '"></div><p class="mb-0">Offline sales</p></div>');
                    text.push('<p class="mb-0">495343</p>');
                    text.push('</div>');
                    text.push('<div class="d-flex justify-content-between mx-4 mx-xl-5 mt-3"><div class="d-flex align-items-center"><div class="mr-3" style="width:20px; height:20px; border-radius: 50%; background-color: ' + chart.data.datasets[0].backgroundColor[1] + '"></div><p class="mb-0">Online sales</p></div>');
                    text.push('<p class="mb-0">630983</p>');
                    text.push('</div>');
                    text.push('<div class="d-flex justify-content-between mx-4 mx-xl-5 mt-3"><div class="d-flex align-items-center"><div class="mr-3" style="width:20px; height:20px; border-radius: 50%; background-color: ' + chart.data.datasets[0].backgroundColor[2] + '"></div><p class="mb-0">Returns</p></div>');
                    text.push('<p class="mb-0">290831</p>');
                    text.push('</div>');
                    text.push('</div>');
                    return text.join("");
                },
            }
            var southAmericaChartPlugins = {
                beforeDraw: function (chart) {
                    var width = chart.chart.width,
                        height = chart.chart.height,
                        ctx = chart.chart.ctx;

                    ctx.restore();
                    var fontSize = 3.125;
                    ctx.font = "600 " + fontSize + "em sans-serif";
                    ctx.textBaseline = "middle";
                    ctx.fillStyle = "#fff";

                    var text = "76",
                        textX = Math.round((width - ctx.measureText(text).width) / 2),
                        textY = height / 2;

                    ctx.fillText(text, textX, textY);
                    ctx.save();
                }
            }
            var southAmericaChartCanvas = $("#south-america-chart-dark").get(0).getContext("2d");
            var southAmericaChart = new Chart(southAmericaChartCanvas, {
                type: 'doughnut',
                data: areaData,
                options: areaOptions,
                plugins: southAmericaChartPlugins
            });
            document.getElementById('south-america-legend').innerHTML = southAmericaChart.generateLegend();
        }

        function format(d) {
            // `d` is the original data object for the row
            return '<table cellpadding="5" cellspacing="0" border="0" style="width:100%;">' +
                '<tr class="expanded-row">' +
                '<td colspan="8" class="row-bg"><div><div class="d-flex justify-content-between"><div class="cell-hilighted"><div class="d-flex mb-2"><div class="mr-2 min-width-cell"><p>Policy start date</p><h6>25/04/2020</h6></div><div class="min-width-cell"><p>Policy end date</p><h6>24/04/2021</h6></div></div><div class="d-flex"><div class="mr-2 min-width-cell"><p>Sum insured</p><h5>$26,000</h5></div><div class="min-width-cell"><p>Premium</p><h5>$1200</h5></div></div></div><div class="expanded-table-normal-cell"><div class="mr-2 mb-4"><p>Quote no.</p><h6>Incs234</h6></div><div class="mr-2"><p>Vehicle Reg. No.</p><h6>KL-65-A-7004</h6></div></div><div class="expanded-table-normal-cell"><div class="mr-2 mb-4"><p>Policy number</p><h6>Incsq123456</h6></div><div class="mr-2"><p>Policy number</p><h6>Incsq123456</h6></div></div><div class="expanded-table-normal-cell"><div class="mr-2 mb-3 d-flex"><div class="highlighted-alpha"> A</div><div><p>Agent / Broker</p><h6>Abcd Enterprices</h6></div></div><div class="mr-2 d-flex"> <img src="../../images/faces/face5.jpg" alt="profile"/><div><p>Policy holder Name & ID Number</p><h6>Phillip Harris / 1234567</h6></div></div></div><div class="expanded-table-normal-cell"><div class="mr-2 mb-4"><p>Branch</p><h6>Koramangala, Bangalore</h6></div></div><div class="expanded-table-normal-cell"><div class="mr-2 mb-4"><p>Channel</p><h6>Online</h6></div></div></div></div></td>'
            '</tr>' +
                '</table>';
        }
        var table = $('#example').DataTable({
            "ajax": "js/data.txt",
            "columns": [
                { "data": "Quote" },
                { "data": "Product" },
                { "data": "Business" },
                { "data": "Policy" },
                { "data": "Premium" },
                { "data": "Status" },
                { "data": "Updated" },
                {
                    "className": 'details-control',
                    "orderable": false,
                    "data": null,
                    "defaultContent": ''
                }
            ],
            "order": [[1, 'asc']],
            "paging": false,
            "ordering": true,
            "info": false,
            "filter": false,
            columnDefs: [{
                orderable: false,
                className: 'select-checkbox',
                targets: 0
            }],
            select: {
                style: 'os',
                selector: 'td:first-child'
            }
        });
        $('#example tbody').on('click', 'td.details-control', function () {
            var tr = $(this).closest('tr');
            var row = table.row(tr);

            if (row.child.isShown()) {
                // This row is already open - close it
                row.child.hide();
                tr.removeClass('shown');
            }
            else {
                // Open this row
                row.child(format(row.data())).show();
                tr.addClass('shown');
            }
        });

    });
})(jQuery);

(function ($) {
    'use strict';
    $(function () {
        $('[data-toggle="offcanvas"]').on("click", function () {
            $('.sidebar-offcanvas').toggleClass('active')
        });
    });
})(jQuery);

(function ($) {
    'use strict';
    //Open submenu on hover in compact sidebar mode and horizontal menu mode
    $(document).on('mouseenter mouseleave', '.sidebar .nav-item', function (ev) {
        var body = $('body');
        var sidebarIconOnly = body.hasClass("sidebar-icon-only");
        var sidebarFixed = body.hasClass("sidebar-fixed");
        if (!('ontouchstart' in document.documentElement)) {
            if (sidebarIconOnly) {
                if (sidebarFixed) {
                    if (ev.type === 'mouseenter') {
                        body.removeClass('sidebar-icon-only');
                    }
                } else {
                    var $menuItem = $(this);
                    if (ev.type === 'mouseenter') {
                        $menuItem.addClass('hover-open')
                    } else {
                        $menuItem.removeClass('hover-open')
                    }
                }
            }
        }
    });
})(jQuery);

(function ($) {
    'use strict';
    $(function () {
        var body = $('body');
        var contentWrapper = $('.content-wrapper');
        var scroller = $('.container-scroller');
        var footer = $('.footer');
        var sidebar = $('.sidebar');

        //Add active class to nav-link based on url dynamically
        //Active class can be hard coded directly in html file also as required

        function addActiveClass(element) {
            if (current === "") {
                //for root url
                if (element.attr('href').indexOf("index.html") !== -1) {
                    element.parents('.nav-item').last().addClass('active');
                    if (element.parents('.sub-menu').length) {
                        element.closest('.collapse').addClass('show');
                        element.addClass('active');
                    }
                }
            } else {
                //for other url
                if (element.attr('href').indexOf(current) !== -1) {
                    element.parents('.nav-item').last().addClass('active');
                    if (element.parents('.sub-menu').length) {
                        element.closest('.collapse').addClass('show');
                        element.addClass('active');
                    }
                    if (element.parents('.submenu-item').length) {
                        element.addClass('active');
                    }
                }
            }
        }

        var current = location.pathname.split("/").slice(-1)[0].replace(/^\/|\/$/g, '');
        $('.nav li a', sidebar).each(function () {
            var $this = $(this);
            addActiveClass($this);
        })

        $('.horizontal-menu .nav li a').each(function () {
            var $this = $(this);
            addActiveClass($this);
        })

        //Close other submenu in sidebar on opening any

        sidebar.on('show.bs.collapse', '.collapse', function () {
            sidebar.find('.collapse.show').collapse('hide');
        });


        //Change sidebar and content-wrapper height
        applyStyles();

        function applyStyles() {
            //Applying perfect scrollbar
            if (!body.hasClass("rtl")) {
                if ($('.settings-panel .tab-content .tab-pane.scroll-wrapper').length) {
                    const settingsPanelScroll = new PerfectScrollbar('.settings-panel .tab-content .tab-pane.scroll-wrapper');
                }
                if ($('.chats').length) {
                    const chatsScroll = new PerfectScrollbar('.chats');
                }
                if (body.hasClass("sidebar-fixed")) {
                    if ($('#sidebar').length) {
                        var fixedSidebarScroll = new PerfectScrollbar('#sidebar .nav');
                    }
                }
            }
        }

        $('[data-toggle="minimize"]').on("click", function () {
            if ((body.hasClass('sidebar-toggle-display')) || (body.hasClass('sidebar-absolute'))) {
                body.toggleClass('sidebar-hidden');
            } else {
                body.toggleClass('sidebar-icon-only');
            }
        });

        //checkbox and radios
        $(".form-check label,.form-radio label").append('<i class="input-helper"></i>');

        //Horizontal menu in mobile
        $('[data-toggle="horizontal-menu-toggle"]').on("click", function () {
            $(".horizontal-menu .bottom-navbar").toggleClass("header-toggled");
        });
        // Horizontal menu navigation in mobile menu on click
        var navItemClicked = $('.horizontal-menu .page-navigation >.nav-item');
        navItemClicked.on("click", function (event) {
            if (window.matchMedia('(max-width: 991px)').matches) {
                if (!($(this).hasClass('show-submenu'))) {
                    navItemClicked.removeClass('show-submenu');
                }
                $(this).toggleClass('show-submenu');
            }
        })

        $(window).scroll(function () {
            if (window.matchMedia('(min-width: 992px)').matches) {
                var header = $('.horizontal-menu');
                if ($(window).scrollTop() >= 70) {
                    $(header).addClass('fixed-on-scroll');
                } else {
                    $(header).removeClass('fixed-on-scroll');
                }
            }
        });
    });

    // focus input when clicking on search icon
    $('#navbar-search-icon').click(function () {
        $("#navbar-search-input").focus();
    });

})(jQuery);

(function ($) {
    'use strict';
    $(function () {
        $(".nav-settings").on("click", function () {
            $("#right-sidebar").toggleClass("open");
        });
        $(".settings-close").on("click", function () {
            $("#right-sidebar,#theme-settings").removeClass("open");
        });

        $("#settings-trigger").on("click", function () {
            $("#theme-settings").toggleClass("open");
        });


        //background constants
        var navbar_classes = "navbar-danger navbar-success navbar-warning navbar-dark navbar-light navbar-primary navbar-info navbar-pink";
        var sidebar_classes = "sidebar-light sidebar-dark";
        var $body = $("body");

        //sidebar backgrounds
        $("#sidebar-light-theme").on("click", function () {
            $body.removeClass(sidebar_classes);
            $body.addClass("sidebar-light");
            $(".sidebar-bg-options").removeClass("selected");
            $(this).addClass("selected");
        });
        $("#sidebar-dark-theme").on("click", function () {
            $body.removeClass(sidebar_classes);
            $body.addClass("sidebar-dark");
            $(".sidebar-bg-options").removeClass("selected");
            $(this).addClass("selected");
        });


        //Navbar Backgrounds
        $(".tiles.primary").on("click", function () {
            $(".navbar").removeClass(navbar_classes);
            $(".navbar").addClass("navbar-primary");
            $(".tiles").removeClass("selected");
            $(this).addClass("selected");
        });
        $(".tiles.success").on("click", function () {
            $(".navbar").removeClass(navbar_classes);
            $(".navbar").addClass("navbar-success");
            $(".tiles").removeClass("selected");
            $(this).addClass("selected");
        });
        $(".tiles.warning").on("click", function () {
            $(".navbar").removeClass(navbar_classes);
            $(".navbar").addClass("navbar-warning");
            $(".tiles").removeClass("selected");
            $(this).addClass("selected");
        });
        $(".tiles.danger").on("click", function () {
            $(".navbar").removeClass(navbar_classes);
            $(".navbar").addClass("navbar-danger");
            $(".tiles").removeClass("selected");
            $(this).addClass("selected");
        });
        $(".tiles.light").on("click", function () {
            $(".navbar").removeClass(navbar_classes);
            $(".navbar").addClass("navbar-light");
            $(".tiles").removeClass("selected");
            $(this).addClass("selected");
        });
        $(".tiles.info").on("click", function () {
            $(".navbar").removeClass(navbar_classes);
            $(".navbar").addClass("navbar-info");
            $(".tiles").removeClass("selected");
            $(this).addClass("selected");
        });
        $(".tiles.dark").on("click", function () {
            $(".navbar").removeClass(navbar_classes);
            $(".navbar").addClass("navbar-dark");
            $(".tiles").removeClass("selected");
            $(this).addClass("selected");
        });
        $(".tiles.default").on("click", function () {
            $(".navbar").removeClass(navbar_classes);
            $(".tiles").removeClass("selected");
            $(this).addClass("selected");
        });
    });
})(jQuery);

(function ($) {
    'use strict';
    $(function () {
        var todoListItem = $('.todo-list');
        var todoListInput = $('.todo-list-input');
        $('.todo-list-add-btn').on("click", function (event) {
            event.preventDefault();

            var item = $(this).prevAll('.todo-list-input').val();

            if (item) {
                todoListItem.append("<li><div class='form-check'><label class='form-check-label'><input class='checkbox' type='checkbox'/>" + item + "<i class='input-helper'></i></label></div><i class='remove ti-close'></i></li>");
                todoListInput.val("");
            }

        });

        todoListItem.on('change', '.checkbox', function () {
            if ($(this).attr('checked')) {
                $(this).removeAttr('checked');
            } else {
                $(this).attr('checked', 'checked');
            }

            $(this).closest("li").toggleClass('completed');

        });

        todoListItem.on('click', '.remove', function () {
            $(this).parent().remove();
        });

    });
})(jQuery);

/*
*   Rounded Rectangle Extension for Bar Charts and Horizontal Bar Charts
*   Tested with Charts.js 2.7.0
*/
Chart.elements.Rectangle.prototype.draw = function () {

    var ctx = this._chart.ctx;
    var vm = this._view;
    var left, right, top, bottom, signX, signY, borderSkipped, radius;
    var borderWidth = vm.borderWidth;

    // If radius is less than 0 or is large enough to cause drawing errors a max
    //      radius is imposed. If cornerRadius is not defined set it to 0.
    var cornerRadius = this._chart.config.options.cornerRadius;
    if (cornerRadius < 0) { cornerRadius = 0; }
    if (typeof cornerRadius == 'undefined') { cornerRadius = 0; }

    if (!vm.horizontal) {
        // bar
        left = vm.x - vm.width / 2;
        right = vm.x + vm.width / 2;
        top = vm.y;
        bottom = vm.base;
        signX = 1;
        signY = bottom > top ? 1 : -1;
        borderSkipped = vm.borderSkipped || 'bottom';
    } else {
        // horizontal bar
        left = vm.base;
        right = vm.x;
        top = vm.y - vm.height / 2;
        bottom = vm.y + vm.height / 2;
        signX = right > left ? 1 : -1;
        signY = 1;
        borderSkipped = vm.borderSkipped || 'left';
    }

    // Canvas doesn't allow us to stroke inside the width so we can
    // adjust the sizes to fit if we're setting a stroke on the line
    if (borderWidth) {
        // borderWidth shold be less than bar width and bar height.
        var barSize = Math.min(Math.abs(left - right), Math.abs(top - bottom));
        borderWidth = borderWidth > barSize ? barSize : borderWidth;
        var halfStroke = borderWidth / 2;
        // Adjust borderWidth when bar top position is near vm.base(zero).
        var borderLeft = left + (borderSkipped !== 'left' ? halfStroke * signX : 0);
        var borderRight = right + (borderSkipped !== 'right' ? -halfStroke * signX : 0);
        var borderTop = top + (borderSkipped !== 'top' ? halfStroke * signY : 0);
        var borderBottom = bottom + (borderSkipped !== 'bottom' ? -halfStroke * signY : 0);
        // not become a vertical line?
        if (borderLeft !== borderRight) {
            top = borderTop;
            bottom = borderBottom;
        }
        // not become a horizontal line?
        if (borderTop !== borderBottom) {
            left = borderLeft;
            right = borderRight;
        }
    }

    ctx.beginPath();
    ctx.fillStyle = vm.backgroundColor;
    ctx.strokeStyle = vm.borderColor;
    ctx.lineWidth = borderWidth;

    // Corner points, from bottom-left to bottom-right clockwise
    // | 1 2 |
    // | 0 3 |
    var corners = [
        [left, bottom],
        [left, top],
        [right, top],
        [right, bottom]
    ];

    // Find first (starting) corner with fallback to 'bottom'
    var borders = ['bottom', 'left', 'top', 'right'];
    var startCorner = borders.indexOf(borderSkipped, 0);
    if (startCorner === -1) {
        startCorner = 0;
    }

    function cornerAt(index) {
        return corners[(startCorner + index) % 4];
    }

    // Draw rectangle from 'startCorner'
    var corner = cornerAt(0);
    ctx.moveTo(corner[0], corner[1]);

    for (var i = 1; i < 4; i++) {
        corner = cornerAt(i);
        nextCornerId = i + 1;
        if (nextCornerId == 4) {
            nextCornerId = 0
        }

        nextCorner = cornerAt(nextCornerId);

        width = corners[2][0] - corners[1][0];
        height = corners[0][1] - corners[1][1];
        x = corners[1][0];
        y = corners[1][1];

        var radius = cornerRadius;
        // Fix radius being too large
        if (radius > Math.abs(height) / 2) {
            radius = Math.floor(Math.abs(height) / 2);
        }
        if (radius > Math.abs(width) / 2) {
            radius = Math.floor(Math.abs(width) / 2);
        }

        if (height < 0) {
            // Negative values in a standard bar chart
            x_tl = x; x_tr = x + width;
            y_tl = y + height; y_tr = y + height;

            x_bl = x; x_br = x + width;
            y_bl = y; y_br = y;

            // Draw
            ctx.moveTo(x_bl + radius, y_bl);
            ctx.lineTo(x_br - radius, y_br);
            ctx.quadraticCurveTo(x_br, y_br, x_br, y_br - radius);
            ctx.lineTo(x_tr, y_tr + radius);
            ctx.quadraticCurveTo(x_tr, y_tr, x_tr - radius, y_tr);
            ctx.lineTo(x_tl + radius, y_tl);
            ctx.quadraticCurveTo(x_tl, y_tl, x_tl, y_tl + radius);
            ctx.lineTo(x_bl, y_bl - radius);
            ctx.quadraticCurveTo(x_bl, y_bl, x_bl + radius, y_bl);

        } else if (width < 0) {
            // Negative values in a horizontal bar chart
            x_tl = x + width; x_tr = x;
            y_tl = y; y_tr = y;

            x_bl = x + width; x_br = x;
            y_bl = y + height; y_br = y + height;

            // Draw
            ctx.moveTo(x_bl + radius, y_bl);
            ctx.lineTo(x_br - radius, y_br);
            ctx.quadraticCurveTo(x_br, y_br, x_br, y_br - radius);
            ctx.lineTo(x_tr, y_tr + radius);
            ctx.quadraticCurveTo(x_tr, y_tr, x_tr - radius, y_tr);
            ctx.lineTo(x_tl + radius, y_tl);
            ctx.quadraticCurveTo(x_tl, y_tl, x_tl, y_tl + radius);
            ctx.lineTo(x_bl, y_bl - radius);
            ctx.quadraticCurveTo(x_bl, y_bl, x_bl + radius, y_bl);

        } else {
            //Positive Value
            ctx.moveTo(x + radius, y);
            ctx.lineTo(x + width - radius, y);
            ctx.quadraticCurveTo(x + width, y, x + width, y + radius);
            ctx.lineTo(x + width, y + height - radius);
            ctx.quadraticCurveTo(x + width, y + height, x + width - radius, y + height);
            ctx.lineTo(x + radius, y + height);
            ctx.quadraticCurveTo(x, y + height, x, y + height - radius);
            ctx.lineTo(x, y + radius);
            ctx.quadraticCurveTo(x, y, x + radius, y);
        }
    }

    ctx.fill();
    if (borderWidth) {
        ctx.stroke();
    }
};
