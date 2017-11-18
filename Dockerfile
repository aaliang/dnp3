FROM centos:7

RUN yum install -y bash \
  boost-devel \
  git \
  centos-release-scl

# dnp3 requires g++ 4.9+. centos/rhel's default yum repo conveniently only installs 4.8
# have to use devtoolset-4 for a more modern version
RUN yum install -y devtoolset-4-gcc-*
RUN yum install -y make cmake autoconf
ENV PATH="/opt/rh/devtoolset-4/root/bin/:${PATH}"

RUN git clone --recursive https://github.com/automatak/dnp3.git
WORKDIR ./dnp3
RUN cmake . && make -j && make install
