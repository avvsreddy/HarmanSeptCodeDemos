// src/app/validators/custom.validators.ts

import { AbstractControl, ValidationErrors, ValidatorFn } from '@angular/forms';

// ... existing code ...

export function noNumberValidator(): ValidatorFn {
    return (control: AbstractControl): ValidationErrors | null => {
        const isValid = !/\d/.test(control.value); // Check for numbers
        return isValid ? null : { noNumber: true }; // Return error if number is found
    };
}

// ... existing code ...