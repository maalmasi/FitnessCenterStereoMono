import React from 'react';
import { observer } from 'mobx-react';
import SimpleInput from './inputs/SimpleInput';

const $btn = 'btn-primary';

     observer(({ form }) => (
  <form onSubmit={form.onSubmit}>
    <SimpleInput field={form.$('FirstName')} />
    <SimpleInput field={form.$('LastName')} />
    <SimpleInput field={form.$('DateHired')} />

    <br />
    <button type="submit" className={$btn} onClick={form.onSubmit}>Submit</button>
    <button type="button" className={$btn} onClick={form.onClear}>Clear</button>
    <button type="button" className={$btn} onClick={form.onReset}>Reset</button>

    <p>{form.error}</p>
  </form>
));
