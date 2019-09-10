import React from 'react';
import './home.css'
class Home extends React.Component
{
    render() {
        return (
            <div class="row">
                <div class="col-lg-6 text-center">
                    <rect>
                        <p className="placeholder">Trainer</p>
                    </rect>
                    <rect>
                        <p className="placeholder">Trainer</p>
                    </rect>
                </div>
                <div class="col-lg-6 text-center">
                    <rect>
                        <p className="placeholder">Trainer</p>
                    </rect>
                    <rect>
                        <p className="placeholder">Trainer</p>
                    </rect>
                </div>
            </div>
        );
    }
}

export default Home;