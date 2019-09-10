import React from 'react';
import { Toast, ToastBody } from 'react-bootstrap';

export default class FormToast extends React.Component {
    render() {
        return (
            <Toast>
                <ToastBody>
                    {this.props.text}
                </ToastBody>
            </Toast>
        )
    }
}