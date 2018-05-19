FROM debian:stretch as base

RUN apt-get update && apt-get install -y libboost-all-dev \
    git \
    build-essential \
    cmake \
    autoconf

RUN git clone --recursive https://github.com/automatak/dnp3.git
WORKDIR /dnp3
RUN git reset --hard f2eaaad736f8469b01916de01ee44fadf80fa1d5 \
 && cmake . \
 && make -j \
 && make install
