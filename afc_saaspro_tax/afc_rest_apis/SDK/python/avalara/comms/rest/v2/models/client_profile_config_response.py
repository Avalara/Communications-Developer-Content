# coding: utf-8

"""
    SaasPro

    APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.<br /><br />Effective January 1st, 2022 all Avalara products will be enforcing TLS 1.2 server-side. Please ensure that your implementation sets a minimal of TLS 1.2 encryption when making web requests to Avalara APIs.  # noqa: E501

    The version of the OpenAPI document: v2
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from avalara.comms.rest.v2.configuration import Configuration


class ClientProfileConfigResponse(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'profile_config_id': 'int',
        'profile_ids': 'list[int]',
        'client_id': 'int',
        'last_update_by': 'str',
        'active': 'bool',
        
        'exclusions': 'list[ExclusionConfig]',
        'bundles': 'list[BundleConfig]',
        'nexus': 'list[NexusConfig]',
        'overrides': 'OverrideConfig',
        'description': 'str',
        'error': 'str',
        'item_type': 'str',
        'errors': 'list[Error]',
        'warnings': 'list[Warning]',
        'status': 'list[Status]'
    }

    attribute_map = {
        'profile_config_id': 'ProfileConfigId',
        'profile_ids': 'ProfileIds',
        'client_id': 'ClientId',
        'last_update_by': 'LastUpdateBy',
        'active': 'Active',
        'settings': 'Settings',
        'exclusions': 'Exclusions',
        'bundles': 'Bundles',
        'nexus': 'Nexus',
        'overrides': 'Overrides',
        'description': 'Description',
        'error': 'Error',
        'item_type': 'ItemType',
        'errors': 'Errors',
        'warnings': 'Warnings',
        'status': 'Status'
    }

    def __init__(self, profile_config_id=None, profile_ids=None, client_id=None, last_update_by=None, active=None, settings=None, exclusions=None, bundles=None, nexus=None, overrides=None, description=None, error=None, item_type=None, errors=None, warnings=None, status=None, local_vars_configuration=None):  # noqa: E501
        """ClientProfileConfigResponse - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._profile_config_id = None
        self._profile_ids = None
        self._client_id = None
        self._last_update_by = None
        self._active = None
        self._settings = None
        self._exclusions = None
        self._bundles = None
        self._nexus = None
        self._overrides = None
        self._description = None
        self._error = None
        self._item_type = None
        self._errors = None
        self._warnings = None
        self._status = None
        self.discriminator = None

        self.profile_config_id = profile_config_id
        self.profile_ids = profile_ids
        self.client_id = client_id
        self.last_update_by = last_update_by
        self.active = active
        if settings is not None:
            self.settings = settings
        self.exclusions = exclusions
        self.bundles = bundles
        self.nexus = nexus
        if overrides is not None:
            self.overrides = overrides
        self.description = description
        self.error = error
        self.item_type = item_type
        self.errors = errors
        self.warnings = warnings
        self.status = status

    @property
    def profile_config_id(self):
        """Gets the profile_config_id of this ClientProfileConfigResponse.  # noqa: E501

        Unique profile configuration id associated with configuration item  # noqa: E501

        :return: The profile_config_id of this ClientProfileConfigResponse.  # noqa: E501
        :rtype: int
        """
        return self._profile_config_id

    @profile_config_id.setter
    def profile_config_id(self, profile_config_id):
        """Sets the profile_config_id of this ClientProfileConfigResponse.

        Unique profile configuration id associated with configuration item  # noqa: E501

        :param profile_config_id: The profile_config_id of this ClientProfileConfigResponse.  # noqa: E501
        :type: int
        """

        self._profile_config_id = profile_config_id

    @property
    def profile_ids(self):
        """Gets the profile_ids of this ClientProfileConfigResponse.  # noqa: E501

        Profile id's associated with configuration item  # noqa: E501

        :return: The profile_ids of this ClientProfileConfigResponse.  # noqa: E501
        :rtype: list[int]
        """
        return self._profile_ids

    @profile_ids.setter
    def profile_ids(self, profile_ids):
        """Sets the profile_ids of this ClientProfileConfigResponse.

        Profile id's associated with configuration item  # noqa: E501

        :param profile_ids: The profile_ids of this ClientProfileConfigResponse.  # noqa: E501
        :type: list[int]
        """

        self._profile_ids = profile_ids

    @property
    def client_id(self):
        """Gets the client_id of this ClientProfileConfigResponse.  # noqa: E501

        Client id associated with configuration item  # noqa: E501

        :return: The client_id of this ClientProfileConfigResponse.  # noqa: E501
        :rtype: int
        """
        return self._client_id

    @client_id.setter
    def client_id(self, client_id):
        """Sets the client_id of this ClientProfileConfigResponse.

        Client id associated with configuration item  # noqa: E501

        :param client_id: The client_id of this ClientProfileConfigResponse.  # noqa: E501
        :type: int
        """

        self._client_id = client_id

    @property
    def last_update_by(self):
        """Gets the last_update_by of this ClientProfileConfigResponse.  # noqa: E501

        User who last updated the configuration item  # noqa: E501

        :return: The last_update_by of this ClientProfileConfigResponse.  # noqa: E501
        :rtype: str
        """
        return self._last_update_by

    @last_update_by.setter
    def last_update_by(self, last_update_by):
        """Sets the last_update_by of this ClientProfileConfigResponse.

        User who last updated the configuration item  # noqa: E501

        :param last_update_by: The last_update_by of this ClientProfileConfigResponse.  # noqa: E501
        :type: str
        """

        self._last_update_by = last_update_by

    @property
    def active(self):
        """Gets the active of this ClientProfileConfigResponse.  # noqa: E501

        Active status of the configuration item  # noqa: E501

        :return: The active of this ClientProfileConfigResponse.  # noqa: E501
        :rtype: bool
        """
        return self._active

    @active.setter
    def active(self, active):
        """Sets the active of this ClientProfileConfigResponse.

        Active status of the configuration item  # noqa: E501

        :param active: The active of this ClientProfileConfigResponse.  # noqa: E501
        :type: bool
        """

        self._active = active

    @property
    def settings(self):
        """Gets the settings of this ClientProfileConfigResponse.  # noqa: E501


        :return: The settings of this ClientProfileConfigResponse.  # noqa: E501
        :rtype: Configuration
        """
        return self._settings

    @settings.setter
    def settings(self, settings):
        """Sets the settings of this ClientProfileConfigResponse.


        :param settings: The settings of this ClientProfileConfigResponse.  # noqa: E501
        :type: Configuration
        """

        self._settings = settings

    @property
    def exclusions(self):
        """Gets the exclusions of this ClientProfileConfigResponse.  # noqa: E501

        Exclusions (as applicable)  # noqa: E501

        :return: The exclusions of this ClientProfileConfigResponse.  # noqa: E501
        :rtype: list[ExclusionConfig]
        """
        return self._exclusions

    @exclusions.setter
    def exclusions(self, exclusions):
        """Sets the exclusions of this ClientProfileConfigResponse.

        Exclusions (as applicable)  # noqa: E501

        :param exclusions: The exclusions of this ClientProfileConfigResponse.  # noqa: E501
        :type: list[ExclusionConfig]
        """

        self._exclusions = exclusions

    @property
    def bundles(self):
        """Gets the bundles of this ClientProfileConfigResponse.  # noqa: E501

        Bundles (as applicable)  # noqa: E501

        :return: The bundles of this ClientProfileConfigResponse.  # noqa: E501
        :rtype: list[BundleConfig]
        """
        return self._bundles

    @bundles.setter
    def bundles(self, bundles):
        """Sets the bundles of this ClientProfileConfigResponse.

        Bundles (as applicable)  # noqa: E501

        :param bundles: The bundles of this ClientProfileConfigResponse.  # noqa: E501
        :type: list[BundleConfig]
        """

        self._bundles = bundles

    @property
    def nexus(self):
        """Gets the nexus of this ClientProfileConfigResponse.  # noqa: E501

        Nexus (as applicable)  # noqa: E501

        :return: The nexus of this ClientProfileConfigResponse.  # noqa: E501
        :rtype: list[NexusConfig]
        """
        return self._nexus

    @nexus.setter
    def nexus(self, nexus):
        """Sets the nexus of this ClientProfileConfigResponse.

        Nexus (as applicable)  # noqa: E501

        :param nexus: The nexus of this ClientProfileConfigResponse.  # noqa: E501
        :type: list[NexusConfig]
        """

        self._nexus = nexus

    @property
    def overrides(self):
        """Gets the overrides of this ClientProfileConfigResponse.  # noqa: E501


        :return: The overrides of this ClientProfileConfigResponse.  # noqa: E501
        :rtype: OverrideConfig
        """
        return self._overrides

    @overrides.setter
    def overrides(self, overrides):
        """Sets the overrides of this ClientProfileConfigResponse.


        :param overrides: The overrides of this ClientProfileConfigResponse.  # noqa: E501
        :type: OverrideConfig
        """

        self._overrides = overrides

    @property
    def description(self):
        """Gets the description of this ClientProfileConfigResponse.  # noqa: E501

        Description associated with this item  # noqa: E501

        :return: The description of this ClientProfileConfigResponse.  # noqa: E501
        :rtype: str
        """
        return self._description

    @description.setter
    def description(self, description):
        """Sets the description of this ClientProfileConfigResponse.

        Description associated with this item  # noqa: E501

        :param description: The description of this ClientProfileConfigResponse.  # noqa: E501
        :type: str
        """

        self._description = description

    @property
    def error(self):
        """Gets the error of this ClientProfileConfigResponse.  # noqa: E501

        Error information.  # noqa: E501

        :return: The error of this ClientProfileConfigResponse.  # noqa: E501
        :rtype: str
        """
        return self._error

    @error.setter
    def error(self, error):
        """Sets the error of this ClientProfileConfigResponse.

        Error information.  # noqa: E501

        :param error: The error of this ClientProfileConfigResponse.  # noqa: E501
        :type: str
        """

        self._error = error

    @property
    def item_type(self):
        """Gets the item_type of this ClientProfileConfigResponse.  # noqa: E501

        Item Type  Examples:    Configuration, Bundle, Exclusion, Override  # noqa: E501

        :return: The item_type of this ClientProfileConfigResponse.  # noqa: E501
        :rtype: str
        """
        return self._item_type

    @item_type.setter
    def item_type(self, item_type):
        """Sets the item_type of this ClientProfileConfigResponse.

        Item Type  Examples:    Configuration, Bundle, Exclusion, Override  # noqa: E501

        :param item_type: The item_type of this ClientProfileConfigResponse.  # noqa: E501
        :type: str
        """

        self._item_type = item_type

    @property
    def errors(self):
        """Gets the errors of this ClientProfileConfigResponse.  # noqa: E501

        Error information.  # noqa: E501

        :return: The errors of this ClientProfileConfigResponse.  # noqa: E501
        :rtype: list[Error]
        """
        return self._errors

    @errors.setter
    def errors(self, errors):
        """Sets the errors of this ClientProfileConfigResponse.

        Error information.  # noqa: E501

        :param errors: The errors of this ClientProfileConfigResponse.  # noqa: E501
        :type: list[Error]
        """

        self._errors = errors

    @property
    def warnings(self):
        """Gets the warnings of this ClientProfileConfigResponse.  # noqa: E501

        Warning information.  # noqa: E501

        :return: The warnings of this ClientProfileConfigResponse.  # noqa: E501
        :rtype: list[Warning]
        """
        return self._warnings

    @warnings.setter
    def warnings(self, warnings):
        """Sets the warnings of this ClientProfileConfigResponse.

        Warning information.  # noqa: E501

        :param warnings: The warnings of this ClientProfileConfigResponse.  # noqa: E501
        :type: list[Warning]
        """

        self._warnings = warnings

    @property
    def status(self):
        """Gets the status of this ClientProfileConfigResponse.  # noqa: E501

        Status information.  # noqa: E501

        :return: The status of this ClientProfileConfigResponse.  # noqa: E501
        :rtype: list[Status]
        """
        return self._status

    @status.setter
    def status(self, status):
        """Sets the status of this ClientProfileConfigResponse.

        Status information.  # noqa: E501

        :param status: The status of this ClientProfileConfigResponse.  # noqa: E501
        :type: list[Status]
        """

        self._status = status

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, ClientProfileConfigResponse):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, ClientProfileConfigResponse):
            return True

        return self.to_dict() != other.to_dict()
