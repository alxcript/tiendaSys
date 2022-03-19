﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaSystem.models {
    public class EntityValidator : IDataErrorInfo {
        
        [Browsable(false)]
        public string this[string property] {
            get {
                var propertyDescriptor = TypeDescriptor.GetProperties(this)[property];
                if(propertyDescriptor == null) {
                    return string.Empty;
                }
                var results = new List<ValidationResult>();
                var result = Validator.TryValidateProperty(propertyDescriptor.GetValue(this), new ValidationContext(this) { MemberName = property }, results);
                if (!result) {
                    return results.First().ErrorMessage;
                }
                return string.Empty;
            }
        }

        [Browsable(false)]
        public string Error {
            get {
                var results = new List<ValidationResult>();
                var result = Validator.TryValidateObject(this, new ValidationContext(this), results, true);
                if (!result) {
                    return string.Join(Environment.NewLine, results.Select(e => e.ErrorMessage));
                }
                return null;
            }
        }

        [Browsable(false)]
        public bool IsValid => string.IsNullOrEmpty(Error);
    }
}
