(function ($, undefined) {
    var kendo = window.kendo;

    var parameterMap = function (options, operation) {
        operation || (operation = "read");

        var results = {};

        if (operation !== "read") {
            if (options.models) {
                var models = options.models;

                for (var i = 0; i < models.length; i++) {
                    fixDataForPost(models[i]);
                }
            } else if (options) {
                fixDataForPost(options);
            }

            //delete options.models;
        }

        return $.extend(results, options)
    };

    var fixDataForPost = function (values) {
        values || (values = {});
        for (var key in values) {
            var value = values[key];

            if (value instanceof Date) {
                //convention to take the date time as UTC as it is stored. 
                var newTime = value.toJSON();
                //var newTime = kendo.toString(value, "u"); 
                //kendo.format("{0:d}", value); 
                //kendo.format("{0:G}", value);
                values[key] = newTime;
            }
            if (value === null) {
                delete values[key];
            }
            if ($.isPlainObject(value)) {
                convert(fixDataForPost(value));
            }
        }
        return values;
    };

    $.extend(true, kendo.data, {
        transports: {
            "orchard" : kendo.data.RemoteTransport.extend({
                init: function(options) {
                    kendo.data.RemoteTransport.fn.init.call(this, $.extend(true, {}, this.options, options));
                },
                read: function(options) {
                    var data = this.options.data,
                        url = this.options.read.url;
                    if (data) {
                        if (url) {
                            this.options.data = null;
                        }

                        if (!data.Data.length && url) {
                            kendo.data.RemoteTransport.fn.read.call(this, options);
                        } else {
                            options.success(data);
                        }
                    } else {
                        kendo.data.RemoteTransport.fn.read.call(this, options);
                    }
                },
                options: {
                    read: {
                        type: "POST",
                        dataType: "json"
                    },
                    update: {
                        type: "POST",
                        dataType: "json"
                    },
                    create: {
                        type: "POST",
                        dataType: "json"
                    },
                    destroy: {
                        type: "POST",
                        dataType: "json"
                    },
                    parameterMap: parameterMap,
                    prefix: ""
                },
                schema: {
                    data: function (response) {
                        return response.Data;
                    },
                    total: function (response) {
                        return response.Total;
                    },
                    errors: function (response) {
                        return response.Errors;
                    }
                }
            })
        }
    });
    $.extend(true, kendo.data, {
        readers: { "orchard" : kendo.data.readers.json }
    });
})(window.kendo.jQuery);
