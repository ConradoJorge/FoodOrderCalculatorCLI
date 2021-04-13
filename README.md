# Food Order Calculator CLI

The Food Order Calculator CLI is designed to resolve an issue which I personally encounter almost every other day. 
Having to calculate manually and fairly how much each person on an order is very tedious. Below is an example order and split.


|  Name | Food  |  Tax | Service Fee | Tips | Total |
|:------|:-----:|:----:|:-----------:|:----:|:-----:|
|Paulene|$ 11.98|$ 0.84|$        0.75|$ 2.04|$ 15.61|
|Aaron  |$  8.99|$ 0.63|$        0.56|$ 1.53|$ 11.71|
|Myrtle |$  9.99|$ 0.70|$        0.62|$ 1.70|$ 13.02|
|Linette|$ 10.49|$ 0.74|$        0.66|$ 1.78|$ 13.66|
|Bill   |$  9.48|$ 0.67|$        0.59|$ 1.61|$ 12.35|

|Category    |Total  |
|:----------:|:-----:|
|Subtotal    |$ 50.93|
|Delivery Fee|$ 0.00 |
|Tax*        |$ 3.58 |
|Service Fee |$ 3.18 |
|Tip         |$ 8.66 |
|Total       |$ 66.36|

## Explanation of each category


### Food
This is the total amount of food ordered by each individual person. The only calculation potentially required is when a single person orders multiple items.



### Tax
This is the sales tax for each person, each delivery service calculates this differently. A service like Grubhub will Tax the Service Fee and Food while Uber Eats will only tax the Food.
Tax is to be calculated without user input, currently there only be support for New Jersey Sales Tax at % 6.625 with support for other states to come at a later date.

### Service Fee
Service Fee is calculated as a percentage of the food items. This number is variable and can range from 0% to 15% (from experience).
Service Fee should be calculated individually for each person.

### Tips
Tip can either be a flat number or a percentage which is added to the order.

### Total
Total calculation is a total of the previous categories.