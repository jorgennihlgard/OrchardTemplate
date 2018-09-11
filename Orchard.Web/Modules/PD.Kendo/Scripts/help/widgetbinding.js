//as the demo http://demos.kendoui.com/web/mvvm/widgets.html
//used to show the look of the controls in the settings menu

var kendoHelp = kendoHelp || (kendoHelp = {
    services: {},
    models: {}
});

(function (d, kendo) {
    var widgetViewModel = function () {
        var viewModel = kendo.observable({
            autoCompleteValue: null,
            colors: [
                { name: "Red", value: "#f00" },
                { name: "Green", value: "#0f0" },
                { name: "Blue", value: "#00f" }
            ],
            displayAutoCompleteValue: function () {
                var autoCompleteValue = this.get("autoCompleteValue");
                return kendo.stringify(autoCompleteValue);
            },
            comboBoxValue: null,
            displayComboBoxValue: function () {
                var comboBoxValue = this.get("comboBoxValue");
                return kendo.stringify(comboBoxValue);
            },
            datePickerValue: new Date(),
            displayDatePickerValue: function () {
                var datePickerValue = this.get("datePickerValue");
                return kendo.toString(datePickerValue, "yyyy-MM-dd");
            },
            dropDownListValue: null,
            displayDropDownListValue: function () {
                var dropDownListValue = this.get("dropDownListValue");
                return kendo.stringify(dropDownListValue);
            },
            multiSelectValue: [],
            displayMultiSelectValue: function () {
                var multiSelectValue = this.get("multiSelectValue");
                return kendo.stringify(multiSelectValue);
            },
            gridSource: [
                { Name: "Chai", Price: 18.00, UnitsInStock: 39 },
                { Name: "Chang", Price: 19.00, UnitsInStock: 17 },
                { Name: "Mishi Kobe Niku", Price: 97.00, UnitsInStock: 29 }
            ],
            displayGridSource: function () {
                return stringify(this.get("gridSource"));
            },
            numericTextBoxValue: 10,
            displayNumericTextBoxValue: function () {
                var numericTextBoxValue = this.get("numericTextBoxValue");

                return kendo.toString(numericTextBoxValue, "c");
            },
            timePickerValue: new Date(),
            displayTimePickerValue: function () {
                var timePickerValue = this.get("timePickerValue");

                return kendo.toString(timePickerValue, "hh:mm:ss");
            },
            treeviewSource: kendo.observableHierarchy([
                {
                    text: "Andrew", expanded: true, items: [
                      { text: "Nancy" },
                      { text: "Steve" }
                    ]
                }
            ]),
            displayTreeviewSource: function () {
                return stringify(this.get("treeviewSource").toJSON());
            }
        });

        viewModel.autoCompleteValue = viewModel.colors[1];
        viewModel.dropDownListValue = viewModel.colors[0];
        viewModel.comboBoxValue = viewModel.colors[0];

        return viewModel;
    };

    kendoHelp.services.widgets = function () {
        var service = this;
        var _ = {
            getViewModel : widgetViewModel
        };

        service.bind = function (jQueryControl) {
            var viewModel = _.getViewModel();
            kendo.bind($(jQueryControl), viewModel);
        }

        return service;
    };
}(Document, kendo));